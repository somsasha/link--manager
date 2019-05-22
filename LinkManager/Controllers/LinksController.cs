using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LinkManager.DAL.Models;
using LinkManager.Services.Interfaces;
using LinkManager.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace LinkManager.Controllers
{
    [Authorize]
    public class LinksController : Controller
    {
        private readonly ILinksService _linksService;

        public LinksController(ILinksService linksService)
        {
            _linksService = linksService;
        }

        // GET: Links
        public IActionResult Index(int page = 0, int pageSize = 10, string tagId = null, string extSearch = null)
        {
            ViewData["Page"] = page;
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
            return View(new LinkIndexViewModel
            {
                Link = links,
                Tags = tags
            });
        }

        // GET: Links/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var link = _linksService.Find(id);
            if (link == null)
            {
                return NotFound();
            }

            return View(link);
        }

        // GET: Links/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Links/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Order,Url,Description,UserId")] Link link, string tags)
        {
            if (ModelState.IsValid)
            {
                _linksService.AssignTags(link, tags);
                if (!link.LinkTags.Any())
                {
                    _linksService.CreateLink(link);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(link);
        }

        // GET: Links/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var link = _linksService.Find(id);
            if (link == null)
            {
                return NotFound();
            }
            return View(link);
        }

        // POST: Links/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, [Bind("Id,Order,Url,Description,UserId")] Link link, string tags)
        {
            if (id != link.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _linksService.UpdateLink(link);
                    var existingLink = _linksService.Find(id);
                    _linksService.AssignTags(existingLink, tags);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LinkExists(link.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(link);
        }

        // GET: Links/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var link = _linksService.Find(id);
            if (link == null)
            {
                return NotFound();
            }

            return View(link);
        }

        // POST: Links/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var link = _linksService.Find(id);
            _linksService.DeleteLink(link);
            return RedirectToAction(nameof(Index));
        }

        private bool LinkExists(string id)
        {
            return _linksService.Find(id) != null;
        }
    }
}
