using System;
using System.Collections.Generic;
using System.Linq;
using LinkManager.Angular.Models;
using LinkManager.Angular.Services.Interfaces;

namespace LinkManager.Angular.Services
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
                var resultTag = _unitOfWork.TagsRepository.Get(_ => _.Name == tag) ?? new Tag { Name = tag };
                resultList.Add(resultTag);
            }

            return resultList;
        }
    }
}
