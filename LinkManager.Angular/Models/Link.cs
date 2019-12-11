using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace LinkManager.Angular.Models
{
    public class Link
    {
        public Link()
        {
        }

        public Link(LinkDTO link)
        {
            Id = link.Id;
            Order = link.Order;
            Url = link.Url;
            Description = link.Description;
            UserId = link.UserId;
        }

        public int Id { get; set; }
        public long Order { get; set; }
        [Url]
        public string Url { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        [JsonIgnore]
        public virtual ApplicationUser User { get; set; }
        public virtual List<LinkTags> LinkTags { get; set; } = new List<LinkTags>();
    }
}
