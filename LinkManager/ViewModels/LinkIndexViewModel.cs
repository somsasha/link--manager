using System.Collections.Generic;
using LinkManager.DAL.Models;

namespace LinkManager.ViewModels
{
    public class LinkIndexViewModel
    {
        public IEnumerable<Link> Link { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
