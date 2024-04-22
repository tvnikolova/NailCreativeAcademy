namespace NailCreativeAcademy.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;
    using Core.Contracts;
    using Core.Models.User;
    using static Core.Constants.AdminConstants;
    using Microsoft.CodeAnalysis.Operations;

    public class UserController : AdminBaseController
    {
        private readonly IUserService userService;
        private readonly IMemoryCache memoryCache;

        public UserController(IUserService _userService,IMemoryCache _memoryCache)
        {
            userService = _userService;
            memoryCache = _memoryCache;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var users = memoryCache.Get<IEnumerable<UserServiceModel>>(UserCacheKey);

            if (users == null || users.Any() == false)
            {
                users = await userService.AllAsync();

                var cache = new MemoryCacheEntryOptions()
                  .SetAbsoluteExpiration(TimeSpan.FromMinutes(2));

                memoryCache.Set(UserCacheKey, users, cache);
            }

            return View(users);
        }

        
        [HttpPost]
        public async Task<IActionResult> All(string searchText)
        {
            var users = await userService.AllAsync();

                if (!String.IsNullOrEmpty(searchText))
                {
                    users = users.Where(u => u.FullName.Contains(searchText)).ToList();
                }

            return View(users);
        }
    }
}
