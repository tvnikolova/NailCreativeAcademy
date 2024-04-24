namespace NailCreativeAcademy.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    using Core.Contracts;
    using Core.Models.Saloon;
    using Core.Services;
    using Infrastructure.Data;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    
  
    using static SeederDataBase;

    public class SaloonServiceTests
    {
        private DbContextOptions<NailCreativeDbContext> dbOptions;
        private NailCreativeDbContext dbContext;
        private IRepository repository;
        private ISaloonService saloonService;
        
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
            saloonService = new SaloonService(repository);
        }
        [SetUp]
        public void Setup()
        {

        }
        
        [Test]
        public async Task AddSaloonSuccessfully()
        {
            SaloonFormModel saloonToAdd = new SaloonFormModel()
            {
              Name = "Nail Beauty",
              Address = "Варна, ул. \"Черноморска\" 2",
              PhoneNumber = "+359886563214",
              ClientId = Student1.Id
            };

            bool isAdded = false;

            int result = await saloonService.AddAsync(saloonToAdd);

            if (result > 0)
            {
                isAdded = true;
            }

            Assert.True(isAdded);
        }

        [Test]
        public async Task EditSaloonSuccessfully()
        {
            repository = new Repository(dbContext);
            saloonService = new SaloonService(repository);

            var saloonToEdit = await repository.All<Saloon>().Where(s => s.Id == Saloon1.Id).FirstAsync();

            SaloonFormModel editedModel = new SaloonFormModel();

         
            if (saloonToEdit != null)
            {
                editedModel.Name = "Nail Beauty V";
                editedModel.Address = Saloon1.Address;
                editedModel.PhoneNumber = "+359888999777";
            }
            
            await saloonService.EditAsync(editedModel, Saloon1.Id);

            Assert.That(Saloon1.Name, Is.EqualTo(editedModel.Name));
            Assert.That(Saloon1.PhoneNumber, Is.EqualTo(editedModel.PhoneNumber));
        }

        [Test]
        public async Task GetAllSaloons()
        {
            var allSaloons = await saloonService.AllAsync();
            Assert.That(3, Is.EqualTo(allSaloons.Count()));
        }

        [Test]
        public async Task GetSaloonFormByIdWork()
        {
            var foundSaloon = await saloonService.GetSaloonFormByIdAsync(Saloon1.Id);
            
            Assert.True(foundSaloon != null);
        }
        [Test]
        public async Task GetSaloonViewModelWork()
        {
            SaloonViewModel foundSaloon = await saloonService.GetSaloonViewModelAsync(Saloon1.Id);
            Saloon saloonInDataBase =await repository.AllReadOnly<Saloon>().Where(s => s.Id == Saloon1.Id).FirstAsync();

            SaloonViewModel viewSaloon = new SaloonViewModel()
            {
                Id = saloonInDataBase.Id,
                Name = saloonInDataBase.Name,
                Address = saloonInDataBase.Address,
                PhoneNumber = saloonInDataBase.PhoneNumber
            };
          Assert.IsTrue(viewSaloon.Id==foundSaloon.Id);
          Assert.IsTrue(viewSaloon.Name == foundSaloon.Name);
          Assert.IsTrue(viewSaloon.Address == foundSaloon.Address);
          Assert.IsTrue(viewSaloon.PhoneNumber == foundSaloon.PhoneNumber);
        }
        [Test]
        public async Task GetSaloonDetailsWork()
        {
            var foundSaloon = await saloonService.DetailsAsync(Saloon1.Id);

            Assert.True(foundSaloon != null);
        }
       
        [Test]
        public async Task DeleteSaloonSuccessfully()
        {
            var salonToDelete = await saloonService.GetSaloonViewModelAsync(4);

            await saloonService.DeleteAsync(salonToDelete.Id);

            var foundSaloon = await repository.GetByIdAsync<Saloon>(salonToDelete.Id);

            Assert.False(foundSaloon != null);
        }
       
    }
}
