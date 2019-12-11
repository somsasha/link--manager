using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using LinkManager.Angular.Models;
using LinkManager.Angular.Services.Comparers;
using LinkManager.Angular.Services.Extensions;
using LinkManager.Angular.Services.Interfaces;

namespace LinkManager.Angular.Services
{
    public class LinksService : ILinksService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ITagsService _tagsService;


        public LinksService(UnitOfWork unitOfWork, ITagsService tagsService)
        {
            _unitOfWork = unitOfWork;
            _tagsService = tagsService;
        }

        public IEnumerable<Link> GetUserLinks(int size, int pageSize, ClaimsPrincipal userClaims, string tagId = null)
        {
            string userId = userClaims.GetUserId();

            Expression<Func<Link, bool>> filterFunc = link => link.UserId == userId;
            if (!string.IsNullOrEmpty(tagId))
                filterFunc = link => link.UserId == userId && link.LinkTags.Select(_ => _.TagId).Contains(int.Parse(tagId));
            var links = _unitOfWork.LinksRepository.GetPageData(size, pageSize, filter: filterFunc,
                includeProperties: new[] {"LinkTags", "LinkTags.Tag"},
                orderBy: queryable => queryable.OrderBy(link => link.Order));

            return links;
        }

        public IEnumerable<Tag> GetMostUsedTags(IEnumerable<Link> links)
        { 
            IEnumerable<List<LinkTags>> linkTags = links.Select(_ => _.LinkTags);
            List<LinkTags> resultList = new List<LinkTags>();
            linkTags.SelectMany(_ =>
            {
                resultList.AddRange(_); return "!";
            }).ToList();
            var mostUsedTags = resultList.Select(_ => _.Tag).GroupBy(_ => _.Id).OrderByDescending(_ => _.Count()).Take(5).Select(_ => _.First());
            return mostUsedTags;
        }

        public Link Find(string id)
        {
            return _unitOfWork.LinksRepository.Get(link => link.Id == int.Parse(id) ,includeProperties: new []{ "LinkTags", "LinkTags.Tag" });
        }

        public IEnumerable<Link> GetAll()
        {
            return _unitOfWork.LinksRepository.GetAll(links => links.OrderBy(_ => _.Order),
                includeProperties: new[] {"LinkTags", "LinkTags.Tag"});
        }

        public Link CreateLink(Link input)
        {
            var addedLink = _unitOfWork.LinksRepository.Create(input);
            _unitOfWork.Save();

            return addedLink;
        }

        public bool UpdateLink(Link link)
        {
            var result = _unitOfWork.LinksRepository.Update(link);
            _unitOfWork.Save();

            return result;
        }

        public bool DeleteLink(Link link)
        {
            var result = _unitOfWork.LinksRepository.Delete(link);
            _unitOfWork.Save();

            return result;
        }

        /// <summary>
        /// Хуй знает как эта ебань работает, но работает)
        /// Ебучий ChangeTracker
        /// </summary>
        /// <param name="link"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public Link AssignTags(Link link, string tags)
        {
            List<LinkTags> linkTags = new List<LinkTags>();

            if (!string.IsNullOrEmpty(tags))
            {
                var resultTags = _tagsService.ProcessTags(tags.Split(',')).ToList();
                resultTags.ForEach(tag =>
                    linkTags.Add(new LinkTags { TagId = tag.Id, Tag = tag, LinkId = link.Id, Link = link}));
            }

            var toDelete = link.LinkTags.Except(linkTags, new LinkTagsComparer()).ToList();
            _unitOfWork.LinkTagsRepository.DeleteRange(toDelete);
            var toAdd = linkTags.Except(link.LinkTags, new LinkTagsComparer()).ToList();
            _unitOfWork.LinkTagsRepository.CreateRange(toAdd);
            _unitOfWork.Save();
            
            return link;
        }
    }
}
