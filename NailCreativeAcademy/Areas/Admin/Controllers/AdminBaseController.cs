namespace NailCreativeAcademy.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static Core.Constants.AdminConstants;

    [Area(AdminAreaName)]
    [Authorize(Roles = RoleAdmin)]
    public class AdminBaseController : Controller
    {

    }
}
