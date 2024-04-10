namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static Constants.NailCreativeConstants;

    public class ApplicationUser :IdentityUser
    {
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = string.Empty;
    }
}
