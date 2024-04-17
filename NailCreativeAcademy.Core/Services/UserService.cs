namespace NailCreativeAcademy.Core.Services
{
    using Contracts;
    using Microsoft.EntityFrameworkCore;
    using Models.User;
    using NailCreativeAcademy.Infrastructure.Data.Common;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public class UserService : IUserService
    {
        private readonly IRepository repository;
        private readonly ICourseService courseService;
        public UserService(IRepository _repository, ICourseService _courseService)
        {
            this.repository = _repository;
            this.courseService = _courseService;
        }
        public async Task<IEnumerable<UserServiceModel>> AllAsync()
        {
            
            var users = await repository.AllReadOnly<ApplicationUser>()
                .Select(u => new UserServiceModel()
                {
                    Id= u.Id,
                    Email = u.Email,
                    FullName = $"{u.FirstName} {u.LastName}"
                })
                .ToListAsync();

            foreach (var user in users)
            {
                user.IsEnrolled= await courseService.StudentHasEnrolledCourse(user.Id);
            }
            return users;
        }
        public async Task<string> UserFullNameAsync(string userId)
        {
            string userName = string.Empty;
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);

            if (user != null)
            {
                userName = $"{user.FirstName} {user.LastName}";
            }

            return userName;
        }
    }
}
