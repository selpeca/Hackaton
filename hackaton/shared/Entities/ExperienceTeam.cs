using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class ExperienceTeam
{
    public int? id { get; set; }

    [Display(Name = "Descripción de experiencia")]
    [Required]
    public string? description { get; set; }

    [Display(Name = "Tiempo de experiencia")]
    [Required]
    public int? time { get; set; }

    // Relaciones
    [JsonIgnore]
    public Team? team { get; set; }
    public int? teamId { get; set; }
}