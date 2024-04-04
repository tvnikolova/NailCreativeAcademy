namespace NailCreativeAcademy.Core.Services
{
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Models.Course;
    using NailCreativeAcademy.Core.Contracts.Course;
    using System.Globalization;
    using static Infrastructure.Constants.NailCreativeConstants;

    public class CourseService : ICourseService
    {
        private readonly IRepository repository;
        public CourseService(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<IEnumerable<CourseViewModel>> All()
        {

            var courses = await repository.AllReadOnly<Course>()
                                           .Select(c => new CourseViewModel()
                                           {
                                               Name = c.Name,
                                               StartDate = c.StartDate.ToString(CultureInfo.InvariantCulture),
                                               Details = c.Details,
                                               Image = c.Image,
                                               Duration = c.Duration,
                                               Price = c.Price,
                                               TrainerId = c.TrainerId,

                                           })
                                           .ToListAsync();

            return courses;

        }

        public async Task<int> CreateAsync(CourseFormModel model, int trainerId)
        {
            Course newCourse = new Course()
            {
                Name = model.Name,
                Details = model.Details,
                StartDate = DateTime.ParseExact(model.StartDate, DateOProjectString, CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact(model.StartDate, DateOProjectString, CultureInfo.InvariantCulture),
                Duration = model.Duration,
                Price = model.Price,
                CourseTypeId = model.CourseTypeId,
                TrainerId = trainerId,
                Image = model.Image,
            };

            await repository.AddAsync(newCourse);
            await repository.SaveChangesAsync();

            return newCourse.Id;
        }

        public async Task<IEnumerable<CourseTypeViewModel>> GetCourseTypesAsync()
        {
            IEnumerable<CourseTypeViewModel> allTypes = await repository.AllReadOnly<CourseType>()
                                                .Select(c => new CourseTypeViewModel()
                                                {
                                                    Id = c.Id,
                                                    Name = c.Name
                                                })
                                                .ToListAsync();
            return allTypes;
        }

        public async Task<bool> CourseExistAsync(string courseName)
        {
            return await repository.AllReadOnly<Course>()
                .AnyAsync(c => c.Name == courseName);
        }
    }
}
