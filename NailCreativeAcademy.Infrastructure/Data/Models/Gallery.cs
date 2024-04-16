namespace NailCreativeAcademy.Infrastructure.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Gallery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
