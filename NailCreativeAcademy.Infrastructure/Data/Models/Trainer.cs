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
        [MaxLength(FirstNameMaxLength)]
        [Comment("Trainer's first name")]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        [MaxLength(LastNameMaxLength)]
        [Comment("Trainer's last name")]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [MaxLength(TrainerDescriptionMaxLength)]
        [Comment("Trainer's description")]
        public string About { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set; }
    }
}
