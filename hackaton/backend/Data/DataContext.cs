using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<People> People { get; set; }
}