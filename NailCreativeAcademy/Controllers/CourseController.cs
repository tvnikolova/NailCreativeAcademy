namespace NailCreativeAcademy.Controllers
{
    using Core.Models.Course;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Contracts;
    using System.Globalization;
    using System.Security.Claims;
    using static Core.Constants.MessageConstants;
    using static Infrastructure.Constants.NailCreativeConstants;

    public class CourseController : BaseController
    {


        private readonly ICourseService courseService;
        private readonly ITrainerService trainerService;

        public CourseController(ICourseService _courseService,
            ITrainerService _trainerService)
        {
            this.courseService = _courseService;
            this.trainerService = _trainerService;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {

            IEnumerable<CourseViewModel> model = await courseService.All();

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {

            if (await courseService.CourseExistByIdAsync(id)==false)
            {
                return BadRequest();
            }

            var model = await courseService.DetailsAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> MyCourses()
        {
            string userId = User.GetUserId();
            IEnumerable<MyCourseModel> model = await courseService.MyCoursesAsync(userId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            if(!User.IsAdmin())
            {
                return Unauthorized();
            }
            CourseFormModel newCourse = new CourseFormModel();

            newCourse.CourseTypes = await courseService.GetCourseTypesAsync();

            return View(newCourse);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseFormModel courseModel, int trainerId)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            if (!DateTime.TryParseExact(courseModel.StartDate, DateOProjectString, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
            {
                ModelState.AddModelError(nameof(courseModel.StartDate), $"Invalid format. The correct format is {DateOProjectString}.");
            }
            if (!DateTime.TryParseExact(courseModel.EndDate, DateOProjectString, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate))
            {
                ModelState.AddModelError(nameof(courseModel.EndDate), $"Invalid format. The correct format is {DateOProjectString}.");
            }

            if (!ModelState.IsValid)
            {
                courseModel.CourseTypes = await courseService.GetCourseTypesAsync();
                return View(courseModel);
            }

            if (await courseService.CourseExistByNameAsync(courseModel.Name) == true)
            {
                ModelState.AddModelError(nameof(courseModel.Name), CourseExists);
            }

            if (await trainerService.TrainerExistByNameAsync(courseModel.Trainer) == false)
            {
                return BadRequest();
            }


            trainerId = await trainerService.GetTrainerId(courseModel.Trainer);

            int newCourseToAdd = await courseService.CreateAsync(courseModel, trainerId);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> CourseProgram(int id)
        {
            if(await courseService.CourseExistByIdAsync(id)==false)
            {
                return BadRequest();
            }

           var  selectedCourse = await courseService.GetMyCourseByIdAsync(id);

            return View(selectedCourse);
        }

        [HttpPost]
        public async Task<IActionResult> Join(int id)
        {
            string userId = User.GetUserId();
            bool enrolledCourse = await courseService.MyCourseExists(userId, id);

            if(enrolledCourse)
            {
                return BadRequest();
            }

            string newCoursetoAdd = await courseService.JoinedCourse(userId, id);

            return RedirectToAction(nameof(MyCourses));
        }


        [HttpPost]       
        public async Task<IActionResult> Leave(int id)
        {
            string userId = User.GetUserId();

            if(!await courseService.MyCourseExists(userId,id))
            {
                return NotFound();
            }

            await courseService.RemoveMyCourse(id, userId);

            return RedirectToAction(nameof(MyCourses));

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            var foundedCourse = await courseService.GetCourseToEditByIdAsync(id);
            var courseTypes = await courseService.GetCourseTypesAsync();

            if(foundedCourse == null)
            {
                return BadRequest();
            }
          
            foundedCourse.CourseTypes = courseTypes;
            return View(foundedCourse);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(CourseFormModel course, int id, int trainerId)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            DateTime startDate = DateTime.Now;
           
            if (!DateTime.TryParseExact(course.StartDate, DateOProjectString, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate))
            {
                ModelState.AddModelError(nameof(course.StartDate), $"Invalid format. The correct format is {DateOProjectString}.");
            }
           
            if (!ModelState.IsValid)
            {
                course.CourseTypes = await courseService.GetCourseTypesAsync();
                return View(course);
            }

            if (await courseService.CourseExistByIdAsync(id) == false)
            {
                ModelState.AddModelError(nameof(course.Name), CourseNotExist);
            }

            if (await trainerService.TrainerExistByNameAsync(course.Trainer) == false)
            {
                return BadRequest();
            }
            


            trainerId = await trainerService.GetTrainerId(course.Trainer);
            await  courseService.EditAsync(course, id, trainerId);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            var foundCourse = await courseService.CourseExistByIdAsync(id);

            if (!foundCourse)
            {
                return BadRequest();
            }
           
            DeleteCourseViewModel courseToDelete = await courseService.GetCourseToDeleteAsync(id);

            return View(courseToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmDelete (int id)
        {
            if (!User.IsAdmin())
            {
                return Unauthorized();
            }
            var foundCourse = await courseService.GetCourseToDeleteAsync(id);

            if(foundCourse == null)
            {
                return BadRequest();
            }
            
                await courseService.DeleteAsync(id);
           
            return RedirectToAction(nameof(All));
        }
    }
}
