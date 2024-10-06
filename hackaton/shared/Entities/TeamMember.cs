using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class TeamMember
{
    public int? id { get; set; }

    [Display(Name = "Rol")]
    [Required]
    public string? role { get; set; }

    // Relaciones
    [JsonIgnore]
    public Participant? participant { get; set; }
    public int? participantId { get; set; }

    [JsonIgnore]
    public Team? team { get; set; }
    public int? teamId { get; set; }
}