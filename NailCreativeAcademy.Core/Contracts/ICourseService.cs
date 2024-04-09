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
        Task<bool> CourseHasEnrolledStudent(int courseId);
        Task<bool> MyCourseExists(string userId, int courseId);
        Task <IEnumerable<MyCourseModel>> MyCoursesAsync(string userId);
        Task<string> JoinedCourse(string userId, int courseId);
        Task <MyCourseModel> GetMyCourseByIdAsync(int id);

        Task<CourseFormModel> GetCourseToEditByIdAsync(int id);


        Task EditAsync(CourseFormModel model, int id, int trainerId);
        Task DeleteAsync(int courseId);

        Task <DeleteCourseViewModel> GetCourseToDeleteAsync(int courseId);
        Task<EnrolledStudent> GetMyEnrolledCourseById(string userId, int courseId);
        Task RemoveMyCourse(int courseId, string userId);
        Task<int> CountOfEnrolledStudents(int courseId);
    }
}
