namespace NailCreativeAcademy.Core.Models.Saloon
{
    using System.ComponentModel.DataAnnotations;
    using static Constants.MessageConstants;
    using static NailCreativeAcademy.Infrastructure.Constants.NailCreativeConstants;

    public class SaloonFormModel
    {
        [Required]
        [StringLength(SaloonNameMaxLength, MinimumLength = SaloonAddressMinLength, ErrorMessage = LengthStringRequired)]
        public string Name {  get; set; } = string.Empty;
        [Required]
        [StringLength(SaloonAddressMaxLength, MinimumLength = SaloonAddressMinLength, ErrorMessage = LengthStringRequired)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(PhoneNumberLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string ClientId = string.Empty;

    }
}
