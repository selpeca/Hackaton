using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class TeamMembers
{
    public int Id { get; set; }
    public int ParticipantId { get; set; }
    public int TeamId { get; set; }
    public string Role { get; set; }

    // Relaciones
    public Participants Participant { get; set; }

    public Teams Team { get; set; }
}