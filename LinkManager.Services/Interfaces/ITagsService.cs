using System.Collections.Generic;
using LinkManager.DAL.Models;

namespace LinkManager.Services.Interfaces
{
    public interface ITagsService
    {
        string ProcessTags(IEnumerable<Tag> tags);
        IEnumerable<Tag> ProcessTags(IEnumerable<string> tags);
    }
}
