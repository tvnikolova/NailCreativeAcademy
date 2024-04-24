namespace NailCreativeAcademy.Tests
{
    
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;
    using System;
    using System.Threading.Tasks;

    using Core.Models.Feedback;
    using Core.Contracts;
    using Core.Services;
    using Infrastructure.Data;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    using static SeederDataBase;
    public class FeedbackServiceTests
    {
        private DbContextOptions<NailCreativeDbContext> dbOptions;
        private NailCreativeDbContext dbContext;
        private IRepository repository;
        private IFeedbackService feedbackService;
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
            feedbackService = new FeedbackService(repository);
        }
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public async Task GetAllFeedbacksToCourse()
        {
            int courseId = Course1.Id;
            var allFeedbacks = await feedbackService.AllAsync(courseId);

            Assert.That(2, Is.EqualTo(allFeedbacks.Count()));
        }
        [Test]
        public async Task AddFeedBackSuccessfully()
        {
            int courseId = Course1.Id;

            FeedbackFormModel feedbackToAdd = new FeedbackFormModel()
            {
                Review = "Курса е невероятен. Препоръчвам го на всеки, " +
                         "който иска да си обогати знанията за рабоита с ел.пила.",
                ClientId = Student1.Id,
                CourseId = Course1.Id,
            };

            bool isAdded = false;

            int result = await feedbackService.AddAsync(feedbackToAdd,courseId);

            if (result > 0)
            {
                isAdded = true;
            }

            Assert.True(isAdded);
        }

        [Test]
        public async Task EditFeedbackSuccessfully()
        {
            var feedbackToEdit = await repository.All<Feedback>().Where(s => s.Id == Feedback1.Id).FirstAsync();
         

            FeedbackFormModel editedModel = new FeedbackFormModel();


            if (feedbackToEdit != null)
            { 
                editedModel.Review = "Препоръчвам курса на 100%";
                editedModel.ClientId = feedbackToEdit.ClientId;
                editedModel.CourseId = feedbackToEdit.CourseId;
            }

            await feedbackService.EditAsync(editedModel, feedbackToEdit.Id);

            Assert.That(Feedback1.Review, Is.EqualTo(editedModel.Review));
            Assert.That(Feedback1.ClientId, Is.EqualTo(editedModel.ClientId));
            Assert.That(Feedback1.CourseId, Is.EqualTo(editedModel.CourseId));
        }

        [Test]
        public async Task GetFeedbackByIdSuccessfully()
        {
            int feedBackId = Feedback1.Id;

            Feedback feedbackInDataBase =
                await repository.AllReadOnly<Feedback>().Where(f => f.Id == feedBackId).FirstAsync();

            var foundFeedback = await feedbackService.GetFeedbackById(feedBackId);

            Assert.True(feedbackInDataBase.Review== foundFeedback.Review);
            Assert.True(feedbackInDataBase.CourseId == foundFeedback.CourseId);
            Assert.True(feedbackInDataBase.ClientId == foundFeedback.ClientId);
        }

        [Test]

        public async Task GetFeedbackToDeleteSuccessfully()
        {
            courseService = new CourseService(repository);
            int feedBackId = Feedback1.Id;

            Feedback feedbackInDataBase =
                await repository.AllReadOnly<Feedback>().Where(f => f.Id == feedBackId).FirstAsync();

            var foundFeedback = await feedbackService.GetFeedbackToDeleteAsync(feedBackId);
            var client = await repository.GetByIdAsync<ApplicationUser>(feedbackInDataBase.ClientId);
            string courseName = await courseService.GetCourseNameByIdAsync(feedbackInDataBase.CourseId);

            string clientName = $"{client.FirstName} {client.LastName}";
           

            Assert.True(feedbackInDataBase.Review == foundFeedback.Review);
            Assert.True(feedbackInDataBase.ClientId == foundFeedback.ClientId);
            Assert.True(courseName == foundFeedback.CourseName);
            Assert.True(clientName == foundFeedback.ClientName);
        }

        [Test]
        public async Task DeleteFeedbackSuccessfully()
        {
            var feedbackToDelete = await feedbackService.GetFeedbackToDeleteAsync(Feedback1.Id);

            await feedbackService.DeleteAsync(feedbackToDelete.Id);

            var foundFeedback = await repository.GetByIdAsync<Feedback>(feedbackToDelete.Id);

            Assert.False(foundFeedback != null);
        }
    }
}
