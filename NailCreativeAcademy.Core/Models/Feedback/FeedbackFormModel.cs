namespace NailCreativeAcademy.Core.Models.Feedback
{
    using System.ComponentModel.DataAnnotations;
    using static Core.Constants.MessageConstants;
    using static Infrastructure.Constants.NailCreativeConstants;

    public class FeedbackFormModel
	{
		
		[Required]
		[StringLength(FeedbackCommentMaxLength, MinimumLength = FeedbackCommentMinLength,
			ErrorMessage = LengthStringRequired)]
		public string Review { get; set; } = string.Empty;

		[Required]		
		public int CourseId { get; set; }
		
		[Required]
		public string ClientId { get; set; } = string.Empty;

        [Required]
        public int FeedbackBoardId { get; set; } 
    }
}
