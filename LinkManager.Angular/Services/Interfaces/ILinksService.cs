using System.Collections.Generic;
using System.Security.Claims;
using LinkManager.Angular.Models;

namespace LinkManager.Angular.Services.Interfaces
{
    public interface ILinksService
    {
        IEnumerable<Link> GetUserLinks(int size, int pageSize, ClaimsPrincipal userClaims, string tagId = null);
        IEnumerable<Tag> GetMostUsedTags(IEnumerable<Link> links);
        Link Find(string id);
        Link CreateLink(Link input);
        bool UpdateLink(Link link);
        bool DeleteLink(Link link);
        Link AssignTags(Link link, string tags);

        IEnumerable<Link> GetAll();
    }
}
