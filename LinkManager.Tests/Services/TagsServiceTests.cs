using System.Collections.Generic;
using System.Linq;
using LinkManager.DAL.Models;
using NUnit.Framework;

namespace LinkManager.Tests.Services
{
    public class TagsServiceTests
    {
        private const int DataCount = 50;

        [OneTimeSetUp]
        public void Setup()
        {
            PrepareData();
        }

        [Test]
        public void TagsServiceProcessTagsFromTagsPositive()
        {
            var tags = new List<Tag>(new[] {new Tag {Name = "NUnit"}, new Tag {Name = "Tags"}});
            var result = GlobalSetup.TagsService.ProcessTags(tags);
            Assert.AreEqual("NUnit,Tags", result);
        }

        [Test]
        public void TagsServiceProcessTagsFromTagsNegative()
        {
            var tags = new List<Tag>(new[] { new Tag { Name = "" }, new Tag { Name = "Tags" } });
            var result = GlobalSetup.TagsService.ProcessTags(tags);
            Assert.AreNotEqual("NUnit,Tags", result);
        }

        [Test]
        public void TagsServiceProcessTagsFromStringPositive()
        {
            var result = GlobalSetup.TagsService.ProcessTags(new []{ "1", "3", "6"});
            Assert.IsNotEmpty(result);
        }

        [Test]
        public void TagsServiceProcessTagsFromStringNegative()
        {
            var result = GlobalSetup.TagsService.ProcessTags(new []{ "0" });
            Assert.False(result.All(_ => !string.IsNullOrWhiteSpace(_.Id)));
        }

        private void PrepareData()
        {
            for (int i = 1; i < DataCount; i++)
            {
                string iS = i.ToString();
                GlobalSetup.UnitOfWork.TagsRepository.Create(new Tag
                {
                    Id = iS,
                    Name = iS
                });
            }
        }
    }
}
