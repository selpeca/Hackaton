namespace shared.Entities;

public class TeamMember
{
    public int? Id { get; set; }
    public int? ParticipantId { get; set; }
    public int? TeamId { get; set; }
    public string? Role { get; set; }

    // Relaciones
    public Participant? Participant { get; set; }

    public Team? Team { get; set; }
}