namespace NailCreativeAcademy.Core.Contracts.Course
{
    using Models.Course;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> All();
        Task<CourseDetailsViewModel> DetailsAsync(int id);
        Task<IEnumerable<CourseTypeViewModel>> GetCourseTypesAsync();
        Task<int> CreateAsync(CourseFormModel model, int trainerId);
        Task<bool> CourseExistAsyncByName(string courseName);
        Task<bool> CourseExistAsyncById(int id);
        Task<bool> MyCourseExists(string userId, int courseId);
        Task <IEnumerable<MyCourseModel>> MyCoursesAsync(string userId);
        Task<string> JoinedCourse(string userId, int courseId);
        Task <MyCourseModel> GetCourseByIdAsync(int id);
        Task<EnrolledStudent> GetMyEnrolledCourseById(string userId, int courseId);
        Task RemoveMyCourse(int courseId, string userId);
    }
}
