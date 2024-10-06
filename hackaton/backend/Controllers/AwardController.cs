using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AwardController : ControllerBase
    {
        private readonly DataContext _context;

        public AwardController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Awards.ToListAsync());
        }

        [HttpGet("ByHackatonId/{hackatonId:int}")]
        public async Task<IActionResult> GetAsyncById(int hackatonId)
        {
            return Ok(await _context.Awards.Where(x => x.hackatonId == hackatonId).ToListAsync());
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var award = await _context.Awards.FindAsync(id);

            if (award == null)
            {
                return NotFound();
            }

            return Ok(award);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Award award)
        {
            _context.Add(award);
            await _context.SaveChangesAsync();
            return Ok(award);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Award award)
        {
            _context.Awards.Update(award);
            await _context.SaveChangesAsync();
            return Ok(award);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var filasafectadas = await _context.Awards
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