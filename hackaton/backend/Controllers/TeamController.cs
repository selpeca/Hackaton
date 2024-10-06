using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamController : ControllerBase
{
    private readonly DataContext _context;

    public TeamController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _context.Teams.ToListAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var team = await _context.Teams.FindAsync(id);

        if (team == null)
        {
            return NotFound();
        }

        return Ok(team);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Team team)
    {
        _context.Add(team);
        await _context.SaveChangesAsync();
        return Ok(team);
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync(Team team)
    {
        _context.Teams.Update(team);
        await _context.SaveChangesAsync();
        return Ok(team);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        var filasafectadas = await _context.Teams
            .Where(x => x.Id == id)
            .ExecuteDeleteAsync();
        if (filasafectadas == 0)
        {
            return NotFound();
        }
        return NoContent();
    }
}
