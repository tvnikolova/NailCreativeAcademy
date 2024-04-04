namespace NailCreativeAcademy.Core.Contracts.Course
{
    using Models.Course;
    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> All();
        Task<IEnumerable<CourseTypeViewModel>> GetCourseTypesAsync();
        Task<int> CreateAsync(CourseFormModel model, int trainerId);
        Task<bool> CourseExistAsync(string courseName);
    }
}
