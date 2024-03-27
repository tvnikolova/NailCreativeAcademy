namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Constants.NailCreativeConstants;
    public class Course
    {
        public Course()
        {
            this.EnrolledStudents = new HashSet<EnrolledStudent>();
           
        }

        [Key]
        [Comment("Course identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CourseNameMaxLength)]
        [Comment("Name of course")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(CourseDescriptionMaxLength)]
        [Comment("Course description")]
        public string Details { get; set; } = string.Empty;

        [Required]
        [Comment("Date of starting course")]
        public DateTime StartDate { get; set; }

        [Required]
        [Comment("End date of course")]
        public DateTime EndDate { get; set; }

        [Required]
        [Comment("Course's image")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Comment("Course price")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [ForeignKey(nameof(Trainer))]
        [Comment("Trainer's id")]
        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(CourseType))]
        [Comment("Course type")]
        public int CourseTypeId { get; set; }
        public virtual CourseType CourseType { get; set; } = null!;
        public ICollection<EnrolledStudent> EnrolledStudents { get; set;}
        
    }
}
