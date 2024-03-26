namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Constants.NailCreativeConstants;
    public class Saloon
    {
        [Key]
        [Comment("Saloon identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(SaloonAddressMaxLength)]
        [Comment("Saloon's address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(PhoneNumberLength)]
        [Comment("Saloon's phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(Client))]
        [Comment("Client identifier")]
        public string ClientId { get; set; } = string.Empty;
        public virtual IdentityUser Client { get; set; } = null!;

    }

}
