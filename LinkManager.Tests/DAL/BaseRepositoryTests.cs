using System;
using System.Linq;
using LinkManager.DAL.Models;
using LinkManager.DAL.Repositories;
using NUnit.Framework;

namespace LinkManager.Tests.DAL
{
    public class BaseRepositoryTests
    {
        private int _initializedDataQuantity = 50;
        private int page = 1;
        private int pageSize = 10;
        private BaseRepository<Link> _linksRepository;

        private Link _linkObj = new Link
        {
            Id = "NUnit",
            Description = "NUnit",
            Url = "NUnit"
        };

        [OneTimeSetUp]
        public void Setup()
        {
            _linksRepository = new BaseRepository<Link>(GlobalSetup.Context);
            InitializeData();
        }

        [Test]
        public void BaseRepositoryGetPositive()
        {
            var assertObj = _linksRepository.Get(_ => _.Id == "1");
            Assert.NotNull(assertObj);
        }

        [Test]
        public void BaseRepositoryGetNegative()
        {
            var assertObj = _linksRepository.Get(_ => _.Id == "0");
            Assert.Null(assertObj);
        }

        [Test]
        public void BaseRepositoryGetAllPositive()
        {
            var assertObj = _linksRepository.GetAll(filter: link => int.Parse(link.Id) > 10, orderBy: links => links.OrderBy(_ => _.Id));
            Assert.IsNotEmpty(assertObj);
        }

        [Test]
        public void BaseRepositoryGetAllNegative()
        {
            var assertObj = _linksRepository.GetAll(filter: link => int.Parse(link.Id) < 0, orderBy: links => links.OrderBy(_ => _.Id));
            Assert.IsEmpty(assertObj);
        }

        [Test]
        public void BaseRepositoryGetPageDataPositive()
        {
            var assertObj = _linksRepository.GetPageData(page, pageSize, filter: link => int.Parse(link.Id) > 10, orderBy: links => links.OrderBy(_ => _.Id));
            Assert.IsNotEmpty(assertObj);
        }

        [Test]
        public void BaseRepositoryGetPageDataNegative()
        {
            var assertObj = _linksRepository.GetPageData(page, pageSize, filter: link => int.Parse(link.Id) < 0, orderBy: links => links.OrderBy(_ => _.Id));
            Assert.IsEmpty(assertObj);
        }

        [Test]
        public void BaseRepositoryCreatePositive()
        {
            var assertObj = _linksRepository.Create(_linkObj);
            Assert.NotNull(assertObj);
        }

        [Test]
        public void BaseRepositoryDeletePositive()
        {
            var random = new Random();
            var assertObj = _linksRepository.Delete(random.Next(_initializedDataQuantity).ToString());
            Assert.True(assertObj);
        }

        [Test]
        public void BaseRepositoryUpdatePositive()
        {
            var random = new Random();
            var linkId = random.Next(_initializedDataQuantity).ToString();
            var existingObj = _linksRepository.Get(_ => _.Id == linkId);
            existingObj.Description = "Updated";
            var assertObj = _linksRepository.Update(existingObj);
            GlobalSetup.UnitOfWork.Save();
            var updatedObj = _linksRepository.Get(_ => _.Id == linkId);
            Assert.Multiple(() =>
            {
                Assert.True(assertObj);
                Assert.NotNull(updatedObj);
            });
        }

        private void InitializeData()
        {
            for (int i = 1; i < _initializedDataQuantity; i++)
            {
                var iS = i.ToString();
                _linksRepository.Create(new Link
                {
                    Id = iS,
                    Description = iS,
                    Order = i,
                    Url = iS
                });
            }
            GlobalSetup.UnitOfWork.Save();
        }
    }
}
