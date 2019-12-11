using System.Collections.Generic;
using LinkManager.Angular.Models;
using Newtonsoft.Json;

namespace LinkManager.Angular.ViewModels
{
    public class LinkIndexViewModel
    {
        public IEnumerable<LinkDTO> Link { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
