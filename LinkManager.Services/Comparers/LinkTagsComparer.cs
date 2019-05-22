using System.Collections.Generic;
using LinkManager.DAL.Models;

namespace LinkManager.Services.Comparers
{
    public class LinkTagsComparer : IEqualityComparer<LinkTags>
    {
        public bool Equals(LinkTags x, LinkTags y)
        {
            if (x.LinkId == y.LinkId &&
                x.TagId == y.TagId)
                return true;

            return false;
        }

        public int GetHashCode(LinkTags obj)
        {
            return (obj.TagId?.GetHashCode()).GetValueOrDefault() + (obj.LinkId?.GetHashCode()).GetValueOrDefault();
        }
    }
}
