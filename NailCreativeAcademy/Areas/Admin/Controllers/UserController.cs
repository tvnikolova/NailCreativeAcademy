using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using NailCreativeAcademy.Core.Contracts;
using NailCreativeAcademy.Core.Models.User;

namespace NailCreativeAcademy.Areas.Admin.Controllers
{
    public class UserController : AdminBaseController
    {
        private readonly IUserService userService;
        private readonly IMemoryCache memoryCache;

        public UserController(
            IUserService _userService,
            IMemoryCache _memoryCache)
        {
            userService = _userService;
            memoryCache = _memoryCache;
        }

        public async Task<IActionResult> All()
        {
            var model = await userService.AllAsync();

            if (model == null || model.Any() == false)
            {
                model = await userService.AllAsync();
            }

            return View(model);
        }
    }
}
