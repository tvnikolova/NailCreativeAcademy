namespace NailCreativeAcademy.Controllers
{
    using Core.Models.Course;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using NailCreativeAcademy.Core.Contracts;
    using System.Globalization;
    using static Core.Constants.MessageConstants;
    using static Infrastructure.Constants.NailCreativeConstants;


    [Authorize]
    public class CourseController : Controller
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
        public async Task<IActionResult> All()
        {

            IEnumerable<CourseViewModel> model = await courseService.All();

            return View(model);
        }

        public IActionResult MyCourses()
        {
            return View(new AllCourseModel());
        }

        [HttpGet]
        public async Task<IActionResult> Create() 
        {
            CourseFormModel newCourse = new CourseFormModel();

            newCourse.CourseTypes = await courseService.GetCourseTypesAsync();

            return View(newCourse);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseFormModel courseModel, int trainerId)
        {

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

            if (await courseService.CourseExistAsync(courseModel.Name)==true)
            {
                ModelState.AddModelError(nameof(courseModel.Name), CourseExists);
            }

            if (await trainerService.TrainerExistAsync(courseModel.Trainer)==false)
            {
                return BadRequest();
            }


            trainerId = await trainerService.GetTrainerId(courseModel.Trainer);

            int newCourseToAdd = await courseService.CreateAsync(courseModel, trainerId);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult ProgramAsync(int id)
        {
            return View(new CourseDetailsViewModel());
        }

        [HttpGet]  
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(int id, CourseFormModel course)
        {
            return RedirectToAction(nameof(ProgramAsync));
        }
    }
}
