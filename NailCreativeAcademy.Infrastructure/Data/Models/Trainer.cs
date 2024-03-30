namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static Constants.NailCreativeConstants;

    public class Trainer
    {
        public Trainer()
        {
            this.Courses = new HashSet<Course>();
        }

        [Key]
        [Comment("Trainer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TrainerNameMaxMinLength)]
        [Comment("Trainer's names")]
        public string Name { get; set; } = string.Empty;
       
        [Required]
        [MaxLength(TrainerDescriptionMaxLength)]
        [Comment("Trainer's information")]
        public string About { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set; }
    }
}
