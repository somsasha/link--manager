using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkManager.Angular.Models
{
    public class LinkDTO
    {
        public LinkDTO()
        {
        }

        public LinkDTO(Link link)
        {
            Id = link.Id;
            Order = link.Order;
            Url = link.Url;
            Description = link.Description;
            TagObjects = link.LinkTags.Select(_ => _.Tag);
            Tags = string.Join(',', TagObjects.Select(_ => _.Name)).TrimEnd(',');
            UserId = link.UserId;
        }

        public int Id { get; set; }
        public long Order { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string UserId { get; set; }
        public IEnumerable<Tag> TagObjects { get; set; }
    }
}
