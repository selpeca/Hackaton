using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamMemberController : ControllerBase
{
    private readonly DataContext _context;

    public TeamMemberController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _context.TeamMembers.ToListAsync());
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetAsync(int id)
    {
        var teamMember = await _context.TeamMembers.FindAsync(id);

        if (teamMember == null)
        {
            return NotFound();
        }

        return Ok(teamMember);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(TeamMember teamMember)
    {
        _context.Add(teamMember);
        await _context.SaveChangesAsync();
        return Ok(teamMember);
    }

    [HttpPut]
    public async Task<IActionResult> PutAsync(TeamMember teamMember)
    {
        _context.TeamMembers.Update(teamMember);
        await _context.SaveChangesAsync();
        return Ok(teamMember);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        var filasafectadas = await _context.TeamMembers
            .Where(x => x.Id == id)
            .ExecuteDeleteAsync();
        if (filasafectadas == 0)
        {
            return NotFound();
        }
        return NoContent();
    }
}
