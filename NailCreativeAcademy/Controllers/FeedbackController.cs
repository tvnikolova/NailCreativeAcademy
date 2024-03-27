using Microsoft.AspNetCore.Mvc;

namespace NailCreativeAcademy.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
