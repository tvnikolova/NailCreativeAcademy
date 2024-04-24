namespace NailCreativeAcademy.Tests
{
    using Core.Contracts;
    using Core.Services;
    using Infrastructure.Data;
    using Infrastructure.Data.Common;
    using Microsoft.EntityFrameworkCore;
    using NailCreativeAcademy.Core.Models.Trainer;
    using NailCreativeAcademy.Infrastructure.Data.Models;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using static SeederDataBase;

    public class TrainerServiceTests
    {
        private DbContextOptions<NailCreativeDbContext> dbOptions;
        private NailCreativeDbContext dbContext;
        private IRepository repository;
        private ITrainerService trainerService;
        private ICourseService courseService;

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
            trainerService = new TrainerService(repository);
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task CreateTrainerSuccessfully()
        {
           
            TrainerFormModel trainerToAdd = new TrainerFormModel()
            {
                Name = "Николина Иванова",
                About = "Николина е обучител от 4 години в академията." +
                        " Тя обучава учениците в сферата на медицински педикюр"
            };


            bool isAdded = false;

            int result = await trainerService.CreateAsync(trainerToAdd);

            if (result > 0)
            {
                isAdded = true;
            }

            Assert.True(isAdded);
        }

        [Test]
        public async Task EditTrainerSuccessfully()
        {

            TrainerFormModel trainerToEdit = new TrainerFormModel()
            {
                Name = "Елена Зойковска",
                About = "Елена Зойкова е международен съдия и обучител." +
                        " Тя е майстор с над 10 години опит в областта на маникюра. " +
                        "Създала е програми за основни и надграждащи курсове. " +
                        "Елена е международен съдия и многократен победител " +
                        "в международни конкурси за ноктопластика."
            };

             await trainerService.EditAsync(trainerToEdit,Trainer3.Id);


            Assert.That(Trainer3.Name, Is.EqualTo(trainerToEdit.Name));
        }
        [Test]
        public async Task GetAllTrainersWork()
        {
            var allTrainers = await trainerService.AllAsync();

            Assert.That(5, Is.EqualTo(allTrainers.Count()));
        }

        [Test]
        public async Task TrainerExistByNameReturnTrue()
        {
            string trainerName = Trainer3.Name;

            bool trainerExist = await trainerService.TrainerExistByNameAsync(trainerName);

            Assert.True(trainerExist);
        }

        [Test]
        public async Task TrainerExistByNameReturnFalse()
        {
            string trainerName = "Иванка Николова";

            bool trainerExist = await trainerService.TrainerExistByNameAsync(trainerName);

            Assert.False(trainerExist);
        }

        [Test]
        public async Task TrainerExistByIdReturnTrue()
        {
            int trainerId = Trainer3.Id;

            bool trainerExist = await trainerService.TrainerExistByIdAsync(trainerId);

            Assert.True(trainerExist);
        }

        [Test]
        public async Task TrainerExistByIdReturnFalse()
        {
            int trainerId = 65;

            bool trainerExist = await trainerService.TrainerExistByIdAsync(trainerId);

            Assert.False(trainerExist);
        }

        [Test]
        public async Task GetTrainerIdSuccessfully()
        {
           string trainerName = Trainer3.Name;

            int trainerId =await  trainerService.GetTrainerId(trainerName);

            Assert.That(20,Is.EqualTo(trainerId));  
        }

        [Test]
        public async Task GetTrainerFormByIdAsyncWork()
        {
            TrainerFormModel trainer = new TrainerFormModel()
            {
                Name = Trainer3.Name,
                About = Trainer3.About
            };

            TrainerFormModel foundTrainer = await trainerService.GetTrainerFormByIdAsync(Trainer3.Id);

            Assert.IsTrue(trainer.Name==foundTrainer.Name);
            Assert.IsTrue(trainer.About == foundTrainer.About);
        }

        [Test]
        public async Task GetTrainerToDeleteWork()
        {
            int trainerId = Trainer3.Id;

            TrainerViewModel trainerToDelete = new TrainerViewModel();

            var foundTrainer = await trainerService.GetTrainerToDeleteAsync(trainerId);
            
            trainerToDelete.Name = foundTrainer.Name;
            trainerToDelete.About = foundTrainer.About;
            trainerToDelete.Id = foundTrainer.Id;

            Assert.IsTrue(trainerToDelete.Id==Trainer3.Id);
            Assert.IsTrue(trainerToDelete.Name == Trainer3.Name);
            Assert.IsTrue(trainerToDelete.About == Trainer3.About);
        }

        [Test]
        public async Task DeleteTrainerWithEnrolledCourse()
        {
            repository = new Repository(dbContext);
            trainerService = new TrainerService(repository); ;
            var trainerForDelete = trainerService.GetTrainerToDeleteAsync(Trainer3.Id);

            bool trainerHasCourseWithStudent = await courseService.CourseHasTrainerAsync(trainerForDelete.Id);
            if (!trainerHasCourseWithStudent)
            {
                await trainerService.DeleteAsync(trainerForDelete.Id);
            }

            var deletedCourse = await repository.GetByIdAsync<Trainer>(trainerForDelete.Id);

            Assert.IsTrue(deletedCourse!=null);
        }

        [Test]

        public async Task DeleteTrainerSuccessfully()
        {
           courseService = new CourseService(repository);

            int trainerId = Trainer4.Id;

            var trainerForDelete = await trainerService.GetTrainerToDeleteAsync(trainerId);
             
            bool trainerHasCourseWithStudent = await courseService.CourseHasTrainerAsync(trainerForDelete.Id);
            if (trainerHasCourseWithStudent==false)
            {
                await trainerService.DeleteAsync(trainerForDelete.Id);
            }

            var deletedCourse = await repository.GetByIdAsync<Trainer>(trainerForDelete.Id);

            Assert.IsTrue(deletedCourse == null);

        }
    }
}
