namespace NailCreativeAcademy.Core.Models.Feedback
{
    using System.ComponentModel.DataAnnotations;
    using static Core.Constants.MessageConstants;
    using static Infrastructure.Constants.NailCreativeConstants;

    public class FeedbackFormModel
	{

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(FeedbackCommentMaxLength, MinimumLength = FeedbackCommentMinLength,
			ErrorMessage = LengthStringRequired)]
		public string Review { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public int CourseId { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public string ClientId { get; set; } = string.Empty;

    }
}
