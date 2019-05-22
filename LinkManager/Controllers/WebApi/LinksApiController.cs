using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LinkManager.DAL.Models;
using LinkManager.Services.Interfaces;

namespace LinkManager.Controllers.WebApi
{
    /// <summary>
    /// Для вида. Не используется
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LinksApiController : Controller
    {
        private readonly ILinksService _linksService;

        public LinksApiController(ILinksService linksService)
        {
            _linksService = linksService;
        }

        // GET: api/LinksApi
        [HttpGet]
        public ActionResult<IEnumerable<Link>> GetLinks()
        {
            return Json(_linksService.GetAll().Select(link =>
            {
                link.LinkTags = new List<LinkTags>();
                return link;
            }).ToList());
        }

        // GET: api/LinksApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Link>> GetLink(string id)
        {
            var link = _linksService.Find(id);

            if (link == null)
            {
                return NotFound();
            }

            return link;
        }

        // PUT: api/LinksApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLink(string id, Link link)
        {
            if (id != link.Id)
            {
                return BadRequest();
            }

            try
            {
                _linksService.UpdateLink(link);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LinksApi
        [HttpPost]
        public async Task<ActionResult<Link>> PostLink(Link link)
        {
            link = _linksService.CreateLink(link);

            return CreatedAtAction("GetLink", new { id = link.Id }, link);
        }

        // DELETE: api/LinksApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Link>> DeleteLink(string id)
        {
            var link =  _linksService.Find(id);
            if (link == null)
            {
                return NotFound();
            }

            _linksService.DeleteLink(link);
            return link;
        }

        private bool LinkExists(string id)
        {
            return _linksService.Find(id) != null;
        }
    }
}
