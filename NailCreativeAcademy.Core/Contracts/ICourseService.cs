namespace NailCreativeAcademy.Core.Contracts.Course
{
    using Models.Course;
    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> All();
        Task<CourseDetailsViewModel> DetailsAsync(int id);
        Task<IEnumerable<CourseTypeViewModel>> GetCourseTypesAsync();
        Task<int> CreateAsync(CourseFormModel model, int trainerId);
        Task<bool> CourseExistAsyncByName(string courseName);
        Task<bool> CourseExistAsyncById(int id);
        Task<bool> MyCourseExists(string userId, int courseId);
        Task <IEnumerable<AllMyCourseModel>> MyCoursesAsync(string userId);
    }
}
