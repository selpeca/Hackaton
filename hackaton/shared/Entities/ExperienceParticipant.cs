using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class ExperienceParticipant
{
    public int? id { get; set; }

    public string? area { get; set; }

    [Display(Name = "Descripción de experiencia")]
    [Required]
    public string? description { get; set; }

    [Display(Name = "Tiempo de experiencia")]
    [Required]
    public int? time { get; set; }

    // Relaciones
    [JsonIgnore]
    public Participant? participant { get; set; }
    public int? participantId { get; set; }
}