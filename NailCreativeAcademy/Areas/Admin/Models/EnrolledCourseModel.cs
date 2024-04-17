namespace NailCreativeAcademy.Areas.Admin.Models
{
    
    using Core.Models.Course;
    
    public class EnrolledCourseModel
    {
        public EnrolledCourseModel()
        {
            this.EnrolledCourses =  new List<CourseViewModel>();
        }
        public IEnumerable<CourseViewModel> EnrolledCourses { get; set; }
    }
}
