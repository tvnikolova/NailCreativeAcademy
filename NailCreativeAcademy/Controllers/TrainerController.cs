using Microsoft.AspNetCore.Mvc;

namespace NailCreativeAcademy.Controllers
{
    public class TrainerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
