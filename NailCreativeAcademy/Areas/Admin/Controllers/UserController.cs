namespace NailCreativeAcademy.Areas.Admin.Controllers
{
    using Core.Contracts;
    using Core.Models.User;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;
    using static Core.Constants.AdminConstants;

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
            List<UserServiceModel> sortеdUsers = new List<UserServiceModel>();

            if (users == null || users.Any() == false)
            {
                users = await userService.AllAsync();
               

                 var cache = new MemoryCacheEntryOptions()
                  .SetAbsoluteExpiration(TimeSpan.FromMinutes(2));

                memoryCache.Set(UserCacheKey, users, cache);
            }
            sortеdUsers = users.OrderBy(u => u.FullName).ToList();
            return View(sortеdUsers);
        }

        
        [HttpPost]
        public async Task<IActionResult> All(string searchText)
        {
            var users = await userService.AllAsync();

                if (!String.IsNullOrEmpty(searchText))
                {
                    users = users.Where(u => u.FullName.Contains(searchText)).OrderBy(u=>u.FullName).ToList();
                }

            return View(users);
        }
       
    }
}
