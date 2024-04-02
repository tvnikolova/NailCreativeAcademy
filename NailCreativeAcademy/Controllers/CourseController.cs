namespace NailCreativeAcademy.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Core.Contracts.Course;
    using Core.Models.Course;



    [Authorize]
    public class CourseController : Controller
    {

        private readonly ICourseService courseService;

        public CourseController(ICourseService _courseService)
        {
            this.courseService = _courseService;
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
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CourseFormModel course)
        {
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
