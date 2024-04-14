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

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CourseNameMaxLength, MinimumLength = CourseNameMinLength,
            ErrorMessage = LengthStringRequired)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CourseDetailsMaxLength, MinimumLength = CourseDetailsMinLength,
            ErrorMessage = LengthStringRequired)]
        public string Details { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string StartDate { get; set; } = string.Empty;
        public string? EndDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public string Image { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(CourseMaxDuration, MinimumLength = CourseMinDuration, ErrorMessage = LengthStringRequired)]
        public string Duration { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),CoursePriceMin,CoursePriceMax,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Цената не може да е отрицателно число.Сумата е най-малко {2} лева.")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Програма")]
        public string Program { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]

        public int CourseTypeId { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public string Trainer { get; set; } = string.Empty;

        public IEnumerable<CourseTypeViewModel> CourseTypes { get; set; }

    }
}