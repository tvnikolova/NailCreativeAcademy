namespace NailCreativeAcademy.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Core.Contracts.Course;
    using Core.Contracts;
    public class TrainerController : Controller
    {
        private readonly ITrainerService trainerService;
        private readonly ICourseService courseService;
        public TrainerController(ITrainerService _trainerService,
            ICourseService _courseService)
        {
            this.trainerService = _trainerService;
            this.courseService = _courseService;

        }

        public async Task<IActionResult> All()
        {
            return View();

        }
    }
}
