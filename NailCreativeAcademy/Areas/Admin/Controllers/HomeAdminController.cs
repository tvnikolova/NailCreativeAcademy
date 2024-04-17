namespace NailCreativeAcademy.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    public class HomeAdminController : AdminBaseController
    {
        public IActionResult Preview()
        {
            return View();
        }
    }
}
