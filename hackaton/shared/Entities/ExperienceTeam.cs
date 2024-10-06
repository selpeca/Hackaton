namespace shared.Entities;

public class ExperienceTeam
{
    public int? Id { get; set; }
    public int? TeamId { get; set; }
    public string? Description { get; set; }
    public TimeSpan? Time { get; set; }

    // Relaciones
    public Team? Team { get; set; }
}