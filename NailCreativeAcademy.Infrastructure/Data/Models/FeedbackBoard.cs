﻿namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    public class FeedbackBoard
    {
        public FeedbackBoard()
        {
            this.Feedbacks = new HashSet<Feedback>();
        }

        [Key]
        [Comment("FeedbackBoard identifier")]
        public int Id { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}