using System.Collections.Generic;
using Newtonsoft.Json;

namespace LinkManager.Angular.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public virtual List<LinkTags> LinkTags { get; set; }
    }
}
