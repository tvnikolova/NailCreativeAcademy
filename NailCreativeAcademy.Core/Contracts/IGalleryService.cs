namespace NailCreativeAcademy.Core.Contracts
{
    using Models.Gallery;

    public interface IGalleryService
    {
        Task<IEnumerable<GalleryViewModel>> AllAsync();
        Task<int> AddImageAsync(GalleryFormModel newImage);
        Task DeleteAsync(int id);
        Task<GalleryViewModel> GetGalleryViewModelAsync(int imageId);
    }
}
