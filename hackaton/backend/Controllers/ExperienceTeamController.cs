using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceParticipantController : ControllerBase
    {
        private readonly DataContext _context;

        public ExperienceParticipantController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.ExperiencesParticipant.ToListAsync());
        }

        [HttpGet("ByParticipantId/{participantId:int}")]
        public async Task<IActionResult> GetAsyncById(int participantId)
        {
            return Ok(await _context.ExperiencesParticipant.Where(x => x.participantId == participantId).ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var experienceTeam = await _context.ExperiencesParticipant.FindAsync(id);

            if (experienceTeam == null)
            {
                return NotFound();
            }

            return Ok(experienceTeam);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ExperienceParticipant experienceParticipant)
        {
            _context.Add(experienceParticipant);
            await _context.SaveChangesAsync();
            return Ok(experienceParticipant);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(ExperienceParticipant experienceParticipant)
        {
            _context.ExperiencesParticipant.Update(experienceParticipant);
            await _context.SaveChangesAsync();
            return Ok(experienceParticipant);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var filasafectadas = await _context.ExperiencesParticipant
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