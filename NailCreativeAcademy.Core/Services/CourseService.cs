namespace NailCreativeAcademy.Core.Services
{
    using Contracts.Course;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Models.Course;
    using System.Globalization;

    public class CourseService:ICourseService
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
                                               Price = c.Price
                                           })
                                           .ToListAsync();

         return courses;
           
        }
    }
}
