namespace NailCreativeAcademy.Core.Models.Saloon
{
    using System.ComponentModel.DataAnnotations;
    using static Constants.MessageConstants;
    using static Infrastructure.Constants.NailCreativeConstants;

    public class SaloonFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(SaloonNameMaxLength, MinimumLength = SaloonAddressMinLength, ErrorMessage = LengthStringRequired)]
        public string Name {  get; set; } = string.Empty;
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(SaloonAddressMaxLength, MinimumLength = SaloonAddressMinLength, ErrorMessage = LengthStringRequired)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PhoneNumberLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string ClientId = string.Empty;

    }
}
