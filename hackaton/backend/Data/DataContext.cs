using Microsoft.EntityFrameworkCore;
using shared.Entities;

namespace backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Person> People { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Award> Awards { get; set; }
    public DbSet<Evaluation> Evaluations { get; set; }
    public DbSet<ExperienceTeam> ExperiencesTeam { get; set; }
    public DbSet<Hackaton> Hackaton { get; set; }
    public DbSet<MentorArea> MentorsArea { get; set; }
    public DbSet<Mentor> Mentors { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Team> Teams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Person>().HasIndex(x => x.Document).IsUnique();
    }
}