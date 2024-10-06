using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class ExperienceTeam
{
    public int Id { get; set; }

    [Display(Name = "Descripción de experiencia")]
    [Required]
    public string Description { get; set; }

    [Display(Name = "Tiempo de experiencia")]
    [Required]
    public int Time { get; set; }

    // Relaciones
    [JsonIgnore]
    public Team Team { get; set; }

    public int TeamId { get; set; }
}