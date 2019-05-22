using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LinkManager.DAL.Models
{
    public class Link
    {
        public string Id { get; set; }
        public long Order { get; set; }
        [Url]
        public string Url { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<LinkTags> LinkTags { get; set; } = new List<LinkTags>();
    }
}
