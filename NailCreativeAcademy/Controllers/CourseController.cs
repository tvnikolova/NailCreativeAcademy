using Microsoft.AspNetCore.Mvc;

namespace NailCreativeAcademy.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
