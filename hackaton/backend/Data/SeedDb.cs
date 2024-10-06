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
            _context.People.Add(new Person { Name = "Sergio", LastName = "Pérez", BirthDate = new DateTime(1997, 6, 30) });
            _context.People.Add(new Person { Name = "Juan José", LastName = "Santana", BirthDate = new DateTime(2000, 5, 4) });
            _context.People.Add(new Person { Name = "Nestor", LastName = "Restrepo", BirthDate = new DateTime(1994, 10, 14) });
        }

        await _context.SaveChangesAsync();
    }
}