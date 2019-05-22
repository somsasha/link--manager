using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace LinkManager.DAL.Models
{
    public class User : IdentityUser
    {
        public virtual IEnumerable<Link> Links { get; set; }
    }
}
