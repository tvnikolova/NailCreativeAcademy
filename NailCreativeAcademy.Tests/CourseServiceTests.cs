namespace NailCreativeAcademy.Tests
{
    using Infrastructure.Data;
    using Microsoft.EntityFrameworkCore;
    using NailCreativeAcademy.Core.Contracts;
    using NailCreativeAcademy.Core.Services;
    using NailCreativeAcademy.Infrastructure.Data.Common;
    using NUnit.Framework;
    using System;
    using System.Threading.Tasks;
    using static SeederDataBase;
    public class CourseServiceTests
    {
        private  DbContextOptions<NailCreativeDbContext> dbOptions;
        private  NailCreativeDbContext dbContext;
        private IRepository repository;
        private ICourseService courseService; 

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            dbOptions = new DbContextOptionsBuilder<NailCreativeDbContext>()
                                 .UseInMemoryDatabase("NailCreativeInMemory"+Guid.NewGuid().ToString())
                                 .Options;

           dbContext=new NailCreativeDbContext(dbOptions);

            dbContext.Database.EnsureCreated();

            SeedDatabase(dbContext);

            courseService = new CourseService(repository);
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task CourseExistByIdAsyncShouldReturnTrue()
        {
            int existingCourseId = Course1.Id;

            bool result =  await courseService.CourseExistByIdAsync(existingCourseId);

            Assert.True(result);
        }

    }
}