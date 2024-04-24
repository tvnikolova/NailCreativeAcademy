using NailCreativeAcademy.Core.Models.User;

namespace NailCreativeAcademy.Tests
{
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Core.Contracts;
    using Core.Services;
    using Infrastructure.Data;
    using Infrastructure.Data.Common;

    using static SeederDataBase;

    
    using Core.Models.Saloon;
    using Core.Services;
    using Infrastructure.Data.Models;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors.Infrastructure;

    public class UserServiceTests
    {
        private DbContextOptions<NailCreativeDbContext> dbOptions;
        private NailCreativeDbContext dbContext;
        private IRepository repository;
        private IUserService userService;
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
            userService = new UserService(repository, courseService);
        }
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task GetUserFullNameSuccessfully()
        {
            string userName = $"{User1.FirstName} {User1.LastName}";

            var user = await userService.UserFullNameAsync(User1.Id);

            Assert.That(userName,Is.EqualTo(user));
        }
        
    }
}
