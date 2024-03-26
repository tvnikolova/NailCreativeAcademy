namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class EnrolledStudent
    {  
       [Required]
       [ForeignKey(nameof(Student))]
       [Comment("Enrolled student's identifier")]
       public string StudentId { get; set; } = string.Empty;
       public virtual IdentityUser Student { get; set; } = null!;

       [Required]
       [ForeignKey(nameof(Course))]
       [Comment("Student's course idenfitier")]
       public int CourseId { get; set; }
       public virtual Course Course { get; set; } = null!;
    }
}
