using LinkManager.DAL;
using LinkManager.DAL.Context;
using LinkManager.DAL.Models;
using LinkManager.Services;
using LinkManager.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace LinkManager.Tests
{
    [SetUpFixture]
    public class GlobalSetup
    {
        public static UnitOfWork UnitOfWork { get; private set; }
        public static ITagsService TagsService { get; private set; }
        public static ILinksService LinksService { get; private set; }
        public static Mock<UserManager<User>> MockUserManager { get; private set; }
        public static ApplicationDbContext Context { get; private set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("NUnit")
                .Options;
            Context = new ApplicationDbContext(options);

            var userStoreMock = new Mock<IUserStore<User>>();
            MockUserManager = new Mock<UserManager<User>>(
                userStoreMock.Object, null, null, null, null, null, null, null, null);

            UnitOfWork = new UnitOfWork(Context);
            TagsService = new TagsService(UnitOfWork);
            LinksService = new LinksService(UnitOfWork, MockUserManager.Object,TagsService);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            LinksService = null;
            TagsService = null;
            MockUserManager = null;
            UnitOfWork = null;
        }
    }
}
