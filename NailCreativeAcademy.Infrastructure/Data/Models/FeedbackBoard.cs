namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    public class FeedbackBoard
    {

        [Key]
        [Comment("Feedback's board identifier")]
        public int Id { get; set; }

    }
}
