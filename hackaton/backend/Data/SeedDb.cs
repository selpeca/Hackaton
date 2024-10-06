using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();

        await CheckPepleAsync();
    }

    private async Task CheckPepleAsync()
    {
        if (!_context.People.Any())
        {
            _context.People.Add(new Person { name = "Sergio", lastName = "Pérez", birthDate = new DateTime(1997, 6, 30) });
            _context.People.Add(new Person { name = "Juan José", lastName = "Santana", birthDate = new DateTime(2001, 5, 10) });
            _context.People.Add(new Person { name = "Nestor", lastName = "Restrepo", birthDate = new DateTime(1994, 10, 14) });
        }

        await _context.SaveChangesAsync();
    }
}