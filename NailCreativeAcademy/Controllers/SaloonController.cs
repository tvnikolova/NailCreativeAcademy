using Microsoft.AspNetCore.Mvc;

namespace NailCreativeAcademy.Controllers
{
    public class SaloonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
