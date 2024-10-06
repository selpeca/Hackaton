using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentorController : ControllerBase
    {
        private readonly DataContext _context;

        public MentorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Mentors.ToListAsync());
        }

        [HttpGet("ByPersonId/{idPerson:int}")]
        public async Task<IActionResult> GetAsyncById(int idPerson)
        {
            return Ok(await _context.Mentors.Where(x => x.personId == idPerson).ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var mentor = await _context.Mentors.FindAsync(id);

            if (mentor == null)
            {
                return NotFound();
            }

            return Ok(mentor);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Mentor mentor)
        {
            _context.Add(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Mentor mentor)
        {
            _context.Mentors.Update(mentor);
            await _context.SaveChangesAsync();
            return Ok(mentor);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var filasafectadas = await _context.Mentors
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