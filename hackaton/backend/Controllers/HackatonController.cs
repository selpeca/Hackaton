using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HackatonController : ControllerBase
    {
        private readonly DataContext _context;

        public HackatonController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Hackaton.ToListAsync());
        }

        [HttpGet("ByProjectId/{projectId:int}")]
        public async Task<IActionResult> GetAsyncById(int projectId)
        {
            return Ok(await _context.Hackaton.Where(x => x.projectId == projectId).ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var hackaton = await _context.Hackaton.FindAsync(id);

            if (hackaton == null)
            {
                return NotFound();
            }

            return Ok(hackaton);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Hackaton hackaton)
        {
            _context.Add(hackaton);
            await _context.SaveChangesAsync();
            return Ok(hackaton);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Hackaton hackaton)
        {
            _context.Hackaton.Update(hackaton);
            await _context.SaveChangesAsync();
            return Ok(hackaton);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var filasafectadas = await _context.Hackaton
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