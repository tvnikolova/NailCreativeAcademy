﻿using System.ComponentModel.DataAnnotations;

namespace NailCreativeAcademy.Core.Models.User
{
    public class UserServiceModel
    {
        public string Id { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [Display(Name ="Full Name")]
        public string FullName { get; set; } = string.Empty;

        public bool IsEnrolled { get; set; }        
    }
}