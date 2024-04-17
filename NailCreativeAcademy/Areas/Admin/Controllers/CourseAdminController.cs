namespace NailCreativeAcademy.Areas.Admin.Controllers
{
    using Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
    using Areas.Admin.Models;

    public class CourseAdminController : AdminBaseController
    {
        private readonly ICourseService courseService;
        public CourseAdminController(ICourseService _courseService)
        {
            this.courseService = _courseService;
        }

        [HttpGet]
        public async Task<IActionResult> EnrolledCourses()
        {
            var enrolledCourses = new EnrolledCourseModel()
            {
                EnrolledCourses = await courseService.GetAllCourseWithEnrolledStudentsAsync()
            };

            return View(enrolledCourses);
        }
    }
}
