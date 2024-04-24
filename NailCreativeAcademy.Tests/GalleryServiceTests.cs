using NailCreativeAcademy.Core.Models.Gallery;

namespace NailCreativeAcademy.Tests
{
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;
    using System;
    using System.Linq;

    using Core.Contracts;
    using Core.Services;
    using Infrastructure.Data;
    using Infrastructure.Data.Common;
    
    using static SeederDataBase;
    using System.Threading.Tasks;
    using NailCreativeAcademy.Core.Models.Saloon;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public class GalleryServiceTests
    {
        private DbContextOptions<NailCreativeDbContext> dbOptions;
        private NailCreativeDbContext dbContext;
        private IRepository repository;
        private IGalleryService galleryService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<NailCreativeDbContext>()
                .UseInMemoryDatabase("NailCreativeInMemory" + Guid.NewGuid().ToString())
                .Options;

            dbContext = new NailCreativeDbContext(dbOptions);

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            SeedDatabase(dbContext);

            repository = new Repository(dbContext);
            galleryService = new GalleryService(repository);
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task AddImageSuccessfully()
        {
            GalleryFormModel galleryToAdd = new GalleryFormModel()
            {
                Name = "Маникюр 1"
            };

            bool isAdded = false;

            int result = await galleryService.AddImageAsync(galleryToAdd);

            if (result > 0)
            {
                isAdded = true;
            }

            Assert.True(isAdded);
        }

        [Test]
        public async Task GetGalleryWork()
        {
            var gallery = await galleryService.AllAsync();


            Assert.That(1, Is.EqualTo(gallery.Count()));
        }

        [Test]
        public async Task GetGalleryViewModelWork()
        {
            GalleryViewModel foundImage = await galleryService.GetGalleryViewModelAsync(Gallery1.Id);
            Gallery imageInDataBase = await repository.AllReadOnly<Gallery>().Where(s => s.Id == Gallery1.Id).FirstAsync();

            SaloonViewModel viewSaloon = new SaloonViewModel()
            {
                Id = imageInDataBase.Id,
                Name = imageInDataBase.Name,
               
            };
            Assert.IsTrue(viewSaloon.Id == foundImage.Id);
            Assert.IsTrue(viewSaloon.Name == foundImage.Name);
           
        }

        [Test]
        public async Task DeleteImageSuccessfully()
        {
            var imageToDelete = await galleryService.GetGalleryViewModelAsync(2);

            await galleryService.DeleteAsync(imageToDelete.Id);

            var foundImage = await repository.GetByIdAsync<Gallery>(imageToDelete.Id);

            Assert.False(foundImage != null);
        }

    }
}
