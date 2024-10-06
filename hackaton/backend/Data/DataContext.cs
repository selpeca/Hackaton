using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<People> People { get; set; }
    public DbSet<TeamMembers> TeamMembers { get; set; }
    public DbSet<Awards> Awards { get; set; }
    public DbSet<Evaluations> Evaluations { get; set; }
    public DbSet<ExperienceTeam> ExperienceTeam { get; set; }
    public DbSet<Hackaton> Hackaton { get; set; }
    public DbSet<MentorArea> MentorArea { get; set; }
    public DbSet<Mentor> Mentor { get; set; }
    public DbSet<Participants> Participants { get; set; }
    public DbSet<Projects> Projects { get; set; }
    public DbSet<Teams> Teams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<People>().HasIndex(x => x.Document).IsUnique();
    }
}