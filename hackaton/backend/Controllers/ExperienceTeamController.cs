using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienceTeamController : ControllerBase
    {
        private readonly DataContext _context;

        public ExperienceTeamController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.ExperiencesTeam.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var experienceTeam = await _context.ExperiencesTeam.FindAsync(id);

            if (experienceTeam == null)
            {
                return NotFound();
            }

            return Ok(experienceTeam);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ExperienceTeam experienceTeam)
        {
            _context.Add(experienceTeam);
            await _context.SaveChangesAsync();
            return Ok(experienceTeam);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(ExperienceTeam experienceTeam)
        {
            _context.ExperiencesTeam.Update(experienceTeam);
            await _context.SaveChangesAsync();
            return Ok(experienceTeam);
        }
        
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var filasafectadas = await _context.ExperiencesTeam
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