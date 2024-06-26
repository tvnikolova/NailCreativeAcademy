﻿namespace NailCreativeAcademy.Core.Models.Trainer
{
    
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Core.Models.Course;
    using static Infrastructure.Constants.NailCreativeConstants;
    using static Core.Constants.MessageConstants;
    
    public class TrainerFormModel
    {

        public TrainerFormModel()
        {
            this.Courses = new List<CourseViewModel>();
        }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TrainerDescriptionMaxLength, MinimumLength = TrainerNameMinLength,
            ErrorMessage = "The fireld {0} is required.The name must be at least {2} symbols.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TrainerDescriptionMaxLength, MinimumLength = TrainerDescriptionMinLength,
            ErrorMessage = "The fireld {0} is required.The name must be at least {2} and maximum {1} symbols.")]
        public string About { get; set; } = string.Empty;

        public IEnumerable<CourseViewModel> Courses { get; set; }

    }
}
