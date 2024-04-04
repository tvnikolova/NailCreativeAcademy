namespace NailCreativeAcademy.Core.Services
{
    using System.Globalization;
    using Microsoft.EntityFrameworkCore;
    using System.Security.Claims;

    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;    
    using Models.Course;
    using Contracts.Course;
    
    
    using static Infrastructure.Constants.NailCreativeConstants;
    using Microsoft.AspNetCore.Identity;

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
                                               Id= c.Id,
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

        public async Task<bool> CourseExistAsyncByName(string courseName)
        {
            return await repository.AllReadOnly<Course>()
                .AnyAsync(c => c.Name == courseName);
        }
        public async Task<bool> CourseExistAsyncById(int id)
        {
            return await repository.AllReadOnly<Course>()
                .AnyAsync(c => c.Id == id);
        }

        public async Task<CourseDetailsViewModel> DetailsAsync(int id)
        {
            CourseDetailsViewModel courses = await repository.AllReadOnly<Course>()
                                            .Where(c=>c.Id == id)
                                            .Select(c => new CourseDetailsViewModel()
                                            {
                                                Id=c.Id,
                                                Name = c.Name,
                                                Details = c.Details,
                                                Image = c.Image,

                                            })
                                            .FirstAsync();

            return courses;
        }

        public async Task<IEnumerable<AllMyCourseModel>> MyCoursesAsync(string userId)
        {
            
            var courses = await repository.AllReadOnly<EnrolledStudent>()
                                            .AsNoTracking()
                                            .Where(s=>s.StudentId == userId)
                                           .Select(es => new AllMyCourseModel()
                                           {
                                              Id = es.CourseId,
                                              Name = es.Course.Name,
                                              Program = es.Course.Program,
                                              Duration = es.Course.Duration,
                                              Image = es.Course.Image,
                                              StartDate = es.Course.StartDate.ToString(DateOProjectString)                                           
                                           })
                                           .ToListAsync();

            return courses;

        }

        public async Task<bool> MyCourseExists(string userId, int courseId)
        {

            return await repository.AllReadOnly<EnrolledStudent>()
                .AnyAsync(c => c.StudentId== userId && c.CourseId== courseId);
            
        }
    }
}
