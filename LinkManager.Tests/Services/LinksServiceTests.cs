using LinkManager.DAL.Models;
using NUnit.Framework;

namespace LinkManager.Tests.Services
{
    public class LinksServiceTests
    {
        private const int DataCount = 50;

        private Link testObj = new Link
        {
            Id = "NUnit123",
            Description = "NUnit",
            Order = 1,
            Url = "NUnit"
        };

        [Test]
        public void LinksServiceFindPositive()
        {
            var result = GlobalSetup.LinksService.Find("1");
            Assert.NotNull(result);
        }

        [Test]
        public void LinksServiceFindNegative()
        {
            var result = GlobalSetup.LinksService.Find("0");
            Assert.Null(result);
        }

        [Test]
        public void LinksServiceCreateLinkPositive()
        {
            var result = GlobalSetup.LinksService.CreateLink(testObj);
            GlobalSetup.LinksService.DeleteLink(testObj);
            Assert.NotNull(result);
        }

        [Test]
        public void LinksServiceDeleteLinkPositive()
        {
            GlobalSetup.LinksService.CreateLink(testObj);
            var result = GlobalSetup.LinksService.DeleteLink(testObj);
            Assert.NotNull(result);
        }

        [Test]
        public void LinksServiceGetAllPositive()
        {
            var result = GlobalSetup.LinksService.GetAll();
            Assert.IsNotEmpty(result);
        }
    }
}
