namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;

    using static Constants.NailCreativeConstants;
    public class CourseType
    {
        public CourseType()
        {
            this.Courses = new HashSet<Course>();
        }
        [Key]
        [Comment("Course type identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CourseTypeNameMaxLength)]
        [Comment("Name of course type")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Course> Courses { get; set; }
    }
}
