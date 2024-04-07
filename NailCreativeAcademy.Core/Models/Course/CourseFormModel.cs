namespace NailCreativeAcademy.Core.Models.Course
{
    using System.ComponentModel.DataAnnotations;
    using static Infrastructure.Constants.NailCreativeConstants;
    using static Constants.MessageConstants;
    public class CourseFormModel
    {
        public CourseFormModel()
        {
            this.CourseTypes = new List<CourseTypeViewModel>();
        }

        [Required]
        [StringLength(CourseNameMaxLength, MinimumLength = CourseNameMinLength,
            ErrorMessage = LengthStringRequired)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(CourseDetailsMaxLength, MinimumLength = CourseDetailsMinLength,
            ErrorMessage = LengthStringRequired)]
        public string Details { get; set; } = string.Empty;

        [Required]
        public string StartDate { get; set; } = string.Empty;
        public string? EndDate { get; set; }

        [Required]
        public string Image { get; set; } = string.Empty;

        [Required]
        [StringLength(CourseMaxDuration, MinimumLength = CourseMinDuration, ErrorMessage = LengthStringRequired)]
        public string Duration { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Program { get; set; } = string.Empty;

        [Required]
        public int CourseTypeId { get; set; }

        [Required]
        public string Trainer { get; set; } = string.Empty;

        public IEnumerable<CourseTypeViewModel> CourseTypes { get; set; }

    }
}