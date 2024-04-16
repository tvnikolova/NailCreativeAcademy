namespace NailCreativeAcademy.Core.Models.Gallery
{
    using System.ComponentModel.DataAnnotations;
    public class GalleryFormModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
