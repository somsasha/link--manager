using System.Collections.Generic;

namespace LinkManager.DAL.Models
{
    public class Tag
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual List<LinkTags> LinkTags { get; set; }
    }
}
