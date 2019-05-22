using LinkManager.DAL.Models;
using LinkManager.Services.Comparers;
using NUnit.Framework;

namespace LinkManager.Tests.Services
{
    public class LinkTagsComparerTests
    {
        private LinkTagsComparer _linkTagsComparer;

        [SetUp]
        public void Setup()
        {
            _linkTagsComparer = new LinkTagsComparer();
        }

        [TearDown]
        public void Teardown()
        {
            _linkTagsComparer = null;
        }

        [Test]
        public void LinkTagsComparerComparePositive()
        {
            var firstObjectToCompare = new LinkTags
            {
                LinkId = "1",
                TagId = "1"
            };

            var secondObjectToCompare = new LinkTags
            {
                LinkId = "1",
                TagId = "1"
            };


            bool result = _linkTagsComparer.Equals(firstObjectToCompare, secondObjectToCompare);
            Assert.True(result);
        }

        [Test]
        public void LinkTagsComparerCompareNegative()
        {
            var firstObjectToCompare = new LinkTags
            {
                LinkId = "2",
                TagId = "1"
            };

            var secondObjectToCompare = new LinkTags
            {
                LinkId = "1",
                TagId = "1"
            };


            bool result = _linkTagsComparer.Equals(firstObjectToCompare, secondObjectToCompare);
            Assert.False(result);
        }
    }
}
