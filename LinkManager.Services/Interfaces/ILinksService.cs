using System.Collections.Generic;
using System.Security.Claims;
using LinkManager.DAL.Models;

namespace LinkManager.Services.Interfaces
{
    public interface ILinksService
    {
        IEnumerable<Link> GetUserLinks(int size, int pageSize, ClaimsPrincipal userClaims, string tagId = null);
        IEnumerable<Tag> GetMostUsedTags(IEnumerable<Link> links);
        Link Find(string id);
        Link CreateLink(Link input);
        bool UpdateLink(Link link);
        bool DeleteLink(Link link);

        /// <summary>
        /// Хуй знает как эта ебань работает, но работает)
        /// Ебучий ChangeTracker
        /// </summary>
        /// <param name="link"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        Link AssignTags(Link link, string tags);

        IEnumerable<Link> GetAll();
    }
}
