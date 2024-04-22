namespace NailCreativeAcademy.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Core.Contracts;
    
    using Core.Models.Trainer;
    using static Core.Constants.MessageConstants;
    using System.Security.Claims;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public class TrainerController : BaseController
    {
        private readonly ITrainerService trainerService;
        private readonly ICourseService courseService;
        public TrainerController(ITrainerService _trainerService,
            ICourseService _courseService)
        {
            this.trainerService = _trainerService;
            this.courseService = _courseService;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            IEnumerable<TrainerViewModel> model = await trainerService.AllAsync();

            return View(model);

        }

        [HttpGet]
        public IActionResult Create()
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            var model = new TrainerFormModel();
             return View(model);
        
        }

        [HttpPost]
        public async Task<IActionResult>Create(TrainerFormModel trainer)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            var foundedTrainer = await trainerService.TrainerExistByNameAsync(trainer.Name);

            if(foundedTrainer)
            {
                ModelState.AddModelError(nameof(trainer.Name), TrinerNameExists);
            }
            if(!ModelState.IsValid)
            {
                return View(trainer);
            }

            int newTrainerId = await trainerService.CreateAsync(trainer);

            TempData[UserAddMessageSuccess] = "Обучителя е добавен!";

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            var foundedTrainer = await trainerService.GetTrainerFormByIdAsync(id);
           
            if (foundedTrainer == null)
            {
                return BadRequest();
            }

          
            return View(foundedTrainer);
        
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(TrainerFormModel trainer, int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            var foundedTrainer = await trainerService.GetTrainerFormByIdAsync(id);

            if (foundedTrainer == null)
            {
                return BadRequest();
            }

            await trainerService.EditAsync(trainer, id);

            TempData[UserAddMessageSuccess] = "Обучителя е редактиран успешно!";

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            TrainerViewModel foundTrainer = await trainerService.GetTrainerToDeleteAsync(id);

            return View(foundTrainer);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            if (!await trainerService.TrainerExistByIdAsync(id))
            {
                return BadRequest();
            }
            var allCourses = await courseService.All();

            bool existCourseWithStudent =false; 

            foreach (var course in allCourses)
            {
                existCourseWithStudent = await courseService.CourseHasEnrolledStudent(course.Id);

                if (existCourseWithStudent && course.TrainerId==id)
                {
                    existCourseWithStudent = true;
                    break;
                }

                
            }
            if(existCourseWithStudent==true)
            {
                return BadRequest();
            }
            else
            {
                await trainerService.DeleteAsync(id);
            }

            TempData[UserAddMessageSuccess] = "Обучителя е премахнат!";
            return RedirectToAction(nameof(All));
        }
       
    }
}
