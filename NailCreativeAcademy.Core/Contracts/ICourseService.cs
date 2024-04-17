namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Course;
    using Infrastructure.Data.Models;

    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> All();
        Task<CourseDetailsViewModel> DetailsAsync(int id);
        Task<int> CreateAsync(CourseFormModel model, int trainerId);
        Task EditAsync(CourseFormModel model, int id, int trainerId);
        Task<IEnumerable<MyCourseModel>> MyCoursesAsync(string userId);
        Task<string> JoinedCourse(string userId, int courseId);
        Task DeleteAsync(int courseId);
        Task<bool> CourseExistByNameAsync(string courseName);
        Task<bool> CourseHasTrainerAsync(int trainerId);
        Task<bool> CourseExistByIdAsync(int id);
        Task<bool> CourseHasEnrolledStudent(int courseId);
        Task<bool> MyCourseExists(string userId, int courseId);        
        Task <MyCourseModel> GetMyCourseByIdAsync(int id);
        Task<CourseFormModel> GetCourseToEditByIdAsync(int id);
        Task<IEnumerable<CourseTypeViewModel>> GetCourseTypesAsync();
        Task<string> GetCourseNameByIdAsync(int courseId);
        Task <DeleteCourseViewModel> GetCourseToDeleteAsync(int courseId);
        Task<EnrolledStudent> GetMyEnrolledCourseById(string userId, int courseId);
        Task<bool> StudentHasEnrolledCourse(string userId);
        Task RemoveMyCourse(int courseId, string userId);
        Task<int> CountOfEnrolledStudents(int courseId);
    }
}
