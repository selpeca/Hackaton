using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentorAreaController : ControllerBase
    {
        private readonly DataContext _context;

        public MentorAreaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.MentorsArea.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var mentorArea = await _context.MentorsArea.FindAsync(id);

            if (mentorArea == null)
            {
                return NotFound();
            }

            return Ok(mentorArea);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(MentorArea mentorArea)
        {
            _context.Add(mentorArea);
            await _context.SaveChangesAsync();
            return Ok(mentorArea);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(MentorArea mentorArea)
        {
            _context.MentorsArea.Update(mentorArea);
            await _context.SaveChangesAsync();
            return Ok(mentorArea);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var filasafectadas = await _context.MentorsArea
                .Where(x => x.id == id)
                .ExecuteDeleteAsync();
            if (filasafectadas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}