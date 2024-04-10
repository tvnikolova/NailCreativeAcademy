namespace NailCreativeAcademy.Core.Models.Saloon
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static NailCreativeAcademy.Infrastructure.Constants.NailCreativeConstants;
    using static Constants.MessageConstants;

    public class SaloonFormModel
    {
        
        [Required]
        [StringLength(SaloonAddressMaxLength, MinimumLength = SaloonAddressMinLength, ErrorMessage = LengthStringRequired)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(PhoneNumberLength)]
        public string PhoneNumber { get; set; } = string.Empty;

    }
}
