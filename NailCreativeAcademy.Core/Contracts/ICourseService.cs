namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Course;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> All();
        Task<IEnumerable<CourseTypeViewModel>> GetCourseTypesAsync();
        Task<int> CreateAsync(CourseFormModel model, int trainerId);
        Task<bool> CourseExistAsync(string courseName);

    }
}
