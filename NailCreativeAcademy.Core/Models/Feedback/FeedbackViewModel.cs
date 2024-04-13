using System.ComponentModel.DataAnnotations;

namespace NailCreativeAcademy.Core.Models.Feedback
{
    public class FeedbackViewModel
    {

        public int Id { get; set; }
        public string Review { get; set; } = string.Empty;
        public string  CourseName { get; set; } = string.Empty;
        public string ClientName { get; set; } = string.Empty;

        public string ClientId { get; set; } = string.Empty;

    }
}
