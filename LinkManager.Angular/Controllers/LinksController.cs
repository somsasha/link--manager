using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using LinkManager.Angular.Models;
using LinkManager.Angular.Services.Extensions;
using LinkManager.Angular.Services.Interfaces;
using LinkManager.Angular.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LinkManager.Angular.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class LinksController : ControllerBase
    {
        private readonly ILinksService _linksService;

        public LinksController(ILinksService linksService)
        {
            _linksService = linksService;
        }

        // GET: api/Links
        [HttpGet]
        public string Get(int page = 0, int pageSize = 10, string tagId = null, string extSearch = null)
        {
            var links = _linksService.GetUserLinks(page, pageSize, User, tagId).ToList();
            if (!string.IsNullOrEmpty(extSearch))
            {
                links = links.Where(_ => Regex.IsMatch(_.Description, extSearch, RegexOptions.IgnoreCase) ||
                                         Regex.IsMatch(_.Order.ToString(), extSearch, RegexOptions.IgnoreCase) ||
                                         Regex.IsMatch(_.Url, extSearch, RegexOptions.IgnoreCase) ||
                                         _.LinkTags.Select(t => t.Tag).Any(tag => Regex.IsMatch(tag.Name, extSearch, RegexOptions.IgnoreCase))).ToList();
            }
            IEnumerable<Tag> tags = new List<Tag>();
            if (links.Any())
            {
                tags = _linksService.GetMostUsedTags(links);
            }

            //И тут меня заебало ебатсья, да будет строка json блять
            var govno = new List<LinkDTO>();
            links.ForEach(_ => govno.Add(new LinkDTO(_)));
            return JsonConvert.SerializeObject(new LinkIndexViewModel
            {
                Link = govno,
                Tags = tags
            });
        }

        // GET: api/Links/5
        [HttpGet("{id}", Name = "Get")]
        public Link Get(string id)
        {
            var link = _linksService.Find(id);

            return link;
        }

        // POST: api/Links
        [HttpPost]
        public Link Post([Bind("Order,Url,Description, Tags")] LinkDTO linkdto)
        {
            var link = new Link(linkdto);
            link.UserId = User.GetUserId();
            Link result = null;
            if (ModelState.IsValid)
            {
                _linksService.AssignTags(link, linkdto.Tags);
                if (!link.LinkTags.Any())
                {
                    result = _linksService.CreateLink(link);
                }
            }
            return result;
        }

        // PUT: api/Links/5
        [HttpPut("{id}")]
        public void Put(string id, [Bind("Id,Order,Url,Description, Tags")] LinkDTO linkdto)
        {
            var link = new Link(linkdto);
            link.UserId = User.GetUserId();
            if (ModelState.IsValid)
            {
                _linksService.UpdateLink(link);
                var existingLink = _linksService.Find(id);
                _linksService.AssignTags(existingLink, linkdto.Tags);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var link = _linksService.Find(id);
            _linksService.DeleteLink(link);
        }
    }
}
