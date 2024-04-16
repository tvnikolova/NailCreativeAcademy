namespace NailCreativeAcademy.Core.Services
{
    using Contracts;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Models.Gallery;

    public class GalleryService : IGalleryService
    {
        private readonly IRepository repository;
        public GalleryService(IRepository _repository)
        {
            this.repository = _repository;
        }

        public async Task<IEnumerable<GalleryViewModel>> AllAsync()
        {
            IEnumerable<GalleryViewModel> gallery = await repository.AllReadOnly<Gallery>()
                                                            .Select(g => new GalleryViewModel()
                                                            {
                                                                Id = g.Id,
                                                                Name = g.Name,

                                                            })
                                                            .ToListAsync();
            return gallery;
        }

        public async Task<int> AddImageAsync(GalleryFormModel newImage)
        {
            Gallery newImageToAdd = new Gallery();

            newImageToAdd.Name = newImage.Name;
          
            await repository.AddAsync(newImageToAdd);
            await repository.SaveChangesAsync();

            return newImageToAdd.Id;
        }

        public async Task DeleteAsync(int imageId)
        {
            var imageToDelete = await GetGalleryViewModelAsync(imageId);

            if (imageToDelete != null)
            {
                await repository.DeleteAsync<Gallery>(imageId);
                await repository.SaveChangesAsync();
            }
        }

        public async Task<GalleryViewModel> GetGalleryViewModelAsync(int imageId)
        {
            var foundImage = await repository.All<Gallery>()
                                              .Where(s => s.Id == imageId)
                                              .Select(s => new GalleryViewModel()
                                              {
                                                  Id = s.Id,
                                                  Name = s.Name,
                                                 
                                              })
                                              .FirstAsync();

            return foundImage;
        }
    }
}
