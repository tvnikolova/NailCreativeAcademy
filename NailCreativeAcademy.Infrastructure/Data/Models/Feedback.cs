﻿namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Constants.NailCreativeConstants;
    public class Feedback
    {
        [Key]
        [Comment("Feedback identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(FeedbackCommentMaxLength)]
        [Comment("Content of the review")]
        public string Review { get; set; } = string.Empty;

        
        [Required]
        [ForeignKey(nameof(Course))]
        [Comment("Identifier of the course to which the feedback is.")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Client))]
        [Comment("Identifier of the client to which the feedback is.")]
        public string ClientId { get; set; } = string.Empty;
        public virtual ApplicationUser Client { get; set; } = null!;

    }
}
