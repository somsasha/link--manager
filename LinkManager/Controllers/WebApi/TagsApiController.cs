using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LinkManager.DAL.Context;
using LinkManager.DAL.Models;

namespace LinkManager.Controllers.WebApi
{
    /// <summary>
    /// Чисто для вида. Не используется нигде
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TagsApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TagsApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TagsApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
        {
            return await _context.Tags.ToListAsync();
        }

        // GET: api/TagsApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tag>> GetTag(string id)
        {
            var tag = await _context.Tags.FindAsync(id);

            if (tag == null)
            {
                return NotFound();
            }

            return tag;
        }

        // PUT: api/TagsApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTag(string id, Tag tag)
        {
            if (id != tag.Id)
            {
                return BadRequest();
            }

            _context.Entry(tag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TagExists(id))
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

        // POST: api/TagsApi
        [HttpPost]
        public async Task<ActionResult<Tag>> PostTag(Tag tag)
        {
            _context.Tags.Add(tag);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTag", new { id = tag.Id }, tag);
        }

        // DELETE: api/TagsApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tag>> DeleteTag(string id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
            {
                return NotFound();
            }

            _context.Tags.Remove(tag);
            await _context.SaveChangesAsync();

            return tag;
        }

        private bool TagExists(string id)
        {
            return _context.Tags.Any(e => e.Id == id);
        }
    }
}
