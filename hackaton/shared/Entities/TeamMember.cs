using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class TeamMember
{
    public int Id { get; set; }

    [Display(Name = "Rol")]
    [Required]
    public string Role { get; set; }

    // Relaciones
    [JsonIgnore]
    public Participant Participant { get; set; }

    public int ParticipantId { get; set; }

    [JsonIgnore]
    public Team Team { get; set; }

    public int TeamId { get; set; }
}