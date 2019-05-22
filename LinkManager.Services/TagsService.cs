using System;
using System.Collections.Generic;
using System.Linq;
using LinkManager.DAL;
using LinkManager.DAL.Models;
using LinkManager.Services.Interfaces;

namespace LinkManager.Services
{
    public class TagsService : ITagsService
    {
        private readonly UnitOfWork _unitOfWork;

        public TagsService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string ProcessTags(IEnumerable<Tag> tags)
        {
            return string.Join(',', tags.Select(_ => _.Name)).TrimEnd(',');
        }

        public IEnumerable<Tag> ProcessTags(IEnumerable<string> tags)
        {
            var resultList = new List<Tag>();
            foreach (var tag in tags)
            {
                var resultTag = _unitOfWork.TagsRepository.Get(t =>
                                    string.Equals(t.Name, tag, StringComparison.InvariantCultureIgnoreCase)) ?? new Tag{ Name = tag };
                resultList.Add(resultTag);
            }

            return resultList;
        }
    }
}
