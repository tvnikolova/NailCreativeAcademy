namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    public class FeedbackBoard
    {
        public FeedbackBoard()
        {
            this.Reviews = new HashSet<Feedback>();
        }

        [Key]
        [Comment("Feedback identifier")]
        public int Id { get; set; }

        public ICollection<Feedback> Reviews { get; set; }
    }
}
