using System.Collections.Generic;
using LinkManager.Angular.Models;

namespace LinkManager.Angular.Services.Interfaces
{
    public interface ITagsService
    {
        string ProcessTags(IEnumerable<Tag> tags);
        IEnumerable<Tag> ProcessTags(IEnumerable<string> tags);
    }
}
