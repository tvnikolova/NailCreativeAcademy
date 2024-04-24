namespace NailCreativeAcademy.Tests
{
    using System.Linq;
    using NUnit.Framework;
    using System;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    using Core.Contracts;
    using Core.Models.Course;
    using Core.Services;
    using Infrastructure.Data;
    using Infrastructure.Data.Common;
    using Infrastructure.Data.Models;
    using static SeederDataBase;

    public class CourseServiceTests
    {
        private DbContextOptions<NailCreativeDbContext> dbOptions;
        private NailCreativeDbContext dbContext;
        private IRepository repository;
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
           
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task CourseExistByIdShouldReturnTrue()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = Course1.Id;

            var result = await courseService.CourseExistByIdAsync(courseId);

            Assert.True(result);
        }
        [Test]
        public async Task CourseNotExistById()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = 44;

            var result = await courseService.CourseExistByIdAsync(courseId);

            Assert.False(result);
        }
        [Test]
        public async Task CourseHasTrainerReturnTrue()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int trainerId = Course1.TrainerId;

            bool result = await courseService.CourseHasTrainerAsync(trainerId);

            Assert.True(result);
        }
        [Test]
        public async Task CourseHasTrainerReturnFalse()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int trainerId = 25;

            bool result = await courseService.CourseHasTrainerAsync(trainerId);

            Assert.IsFalse(result);
        }
        [Test]
        public async Task RemoveMyCourseSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = Course1.Id;
            string studentId = Student1.Id;

            var myEnrolledCourse = await courseService.GetMyEnrolledCourseById(studentId, courseId);

            if (myEnrolledCourse != null)
            {
                await courseService.RemoveMyCourse(courseId, studentId);
            }
            
            bool allEnrolledCourses = await courseService.MyCourseExists(studentId, courseId);

           Assert.False(allEnrolledCourses);
        }

        [Test]
        public async Task JoinCourseToMyCourse()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = Course1.Id;
            string studentId = Student1.Id;

            bool allEnrolledCourses = await courseService.MyCourseExists(studentId, courseId);

            if (!allEnrolledCourses)
            {
                await courseService.JoinedCourse(studentId, courseId);
            }

            bool courseEnrolled = await courseService.MyCourseExists(studentId, courseId);

            Assert.IsTrue(courseEnrolled);
        }

        [Test]
        public async Task CourseHasEnrolledCourseReturnFalse()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);
            int courseId = 32;

            bool result = await courseService.CourseHasEnrolledStudent(courseId);

            Assert.IsFalse(result);
        }
        
        [Test]
        public async Task EditCourseSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);
            

            await courseService.EditAsync(new CourseFormModel()
            {
                Name = " ŒÃ¡»Õ»–¿Õ ¿œ¿–¿“≈Õ Ã¿Õ» ﬁ–",
                Details = " ÓÏ·ËÌË‡Ì ‡Ô‡‡ÚÂÌ Ï‡ÌËÍ˛-‰ÂÚ‡ÈÎË",
                StartDate = "20/06/2024 03:30",
                EndDate = "22/06/2024 17:30",
                Duration = "50 ˜‡Ò‡",
                CourseTypeId = 4,
                Program = " ÓÏ·ËÌË‡Ì ‡Ô‡‡ÚÂÌ Ï‡ÌËÍ˛-ÔÓ„‡Ï‡",
                Price = 420.00m
            },
            Course1.Id, Course1.TrainerId);

            var courseToEdit = await courseService.GetCourseToEditByIdAsync(Course1.Id);

                Assert.That(courseToEdit.Duration, Is.EqualTo("50 ˜‡Ò‡"));
        }

        [Test]
        public async Task CreateCourseSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int trainerId = Trainer3.Id;
            CourseFormModel courseToAdd = new CourseFormModel()
            {
                Name = "œÂ‰ËÍ˛",
                Details = "œÂ‰ËÍ˛-‰ÂÚ‡ÈÎË",
                StartDate = "20/07/2024 03:30",
                EndDate = "22/07/2024 17:30",
                Duration = "30 ˜‡Ò‡",
                CourseTypeId = 3,
                Program = "œÂ‰ËÍ˛-ÔÓ„‡Ï‡",
                Price = 430.00m
            };

            bool isAdded = false;

            int result = await courseService.CreateAsync(courseToAdd, trainerId);

            if (result>0)
            {
                isAdded= true;
            }
            Assert.True(isAdded);
        }
        [Test]
        public async Task GetAllCoursesSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            var allCourses = await courseService.All();

            Assert.That(3, Is.EqualTo(allCourses.Count()));
        }
        [Test]
        public async Task DeleteCourseNotSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            var courseHasStudent = await courseService.CourseHasEnrolledStudent(Course1.Id);

            Assert.IsFalse(!courseHasStudent);
        }
        [Test]
        public async Task DeleteCourseSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            var courseForDelete = courseService.GetCourseToDeleteAsync(Course2.Id);
            bool courseHasStudent = await courseService.CourseHasEnrolledStudent(courseForDelete.Id);

            if(!courseHasStudent) 
            {

                await courseService.DeleteAsync(courseForDelete.Id);
            }
            
            var foundCourse = await repository.GetByIdAsync<Course>(courseForDelete.Id);

            Assert.IsTrue(foundCourse == null);
        }

        [Test]
        public async Task GetCourseTypesAsyncSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            var allCourseTypes = await courseService.GetCourseTypesAsync();

            Assert.IsTrue(allCourseTypes.Any());
        }

        [Test]
        public async Task MyCoursesSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            string studentId = Student1.Id;
            var allMyCourses = await courseService.MyCoursesAsync(studentId);

          
            Assert.IsTrue(allMyCourses.Any());
        }

        [Test]
        public async Task CourseExistByNameReturnTrue()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            string courseName = Course1.Name;

            bool existCourseByName = await courseService.CourseExistByNameAsync(courseName);

            Assert.IsTrue(existCourseByName);
        }
        [Test]
        public async Task CourseNotExistByNameAsync()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            string courseName = "Ã‡ÒÚÂ ÍÎ‡Ò ÔÓ Ï‡ÌËÍ˛";

            bool existCourseByName = await courseService.CourseExistByNameAsync(courseName);

            Assert.IsFalse(existCourseByName);
        }

        [Test]
        public async Task GetCourseNameByIdSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = Course1.Id;

           string courseName = await courseService.GetCourseNameByIdAsync(courseId);

            Assert.That(" ŒÃ¡»Õ»–¿Õ ¿œ¿–¿“≈Õ Ã¿Õ» ﬁ–",Is.EqualTo(courseName));
        }
        [Test]
        public async Task GetCourseNameByIdNotWork()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = Course1.Id;

            string courseName = await courseService.GetCourseNameByIdAsync(courseId);

          
            Assert.IsTrue(courseName!= " ŒÃ¡»Õ»–¿Õ Ã¿Õ» ﬁ–");
        }

        [Test]
        public async Task CountOfEnrolledStudentsSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = Course1.Id;

            int enrolledStudentCount = await courseService.CountOfEnrolledStudents(courseId);

            Assert.That(1, Is.EqualTo(enrolledStudentCount));
        }
        [Test]
        public async Task StudentHasEnrolledCourseReturnFalse()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            string studentId = Student1.Id;

            bool hasEnrolledStudents = await courseService.StudentHasEnrolledCourse(studentId);

            Assert.IsFalse(hasEnrolledStudents);
        }

        [Test]
        public async Task GetAllCourseWithEnrolledStudentsSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            var allEnrolledCourses = await courseService.GetAllCourseWithEnrolledStudentsAsync();

            Assert.That(1,Is.EqualTo(allEnrolledCourses.Count()));
        }


        [Test]
        public async Task DetailsSuccessfully()
        {
            repository = new Repository(dbContext);
            courseService = new CourseService(repository);

            int courseId = Course1.Id;
            var courseDetails = await courseService.DetailsAsync(courseId);

            Assert.IsTrue(courseDetails!=null);
        }
    }
}