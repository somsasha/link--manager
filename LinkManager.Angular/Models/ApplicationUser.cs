using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace LinkManager.Angular.Models
{
    public class ApplicationUser : IdentityUser 
    {
        public virtual IEnumerable<Link> Links { get; set; }
    }
}
