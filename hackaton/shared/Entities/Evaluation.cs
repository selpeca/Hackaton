using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Evaluation
{
    public int? id { get; set; }

    [Display(Name = "Criterio")]
    [Required]
    public string? judgment { get; set; }

    [Display(Name = "Puntuación")]
    [Required]
    public int? score { get; set; }

    [Display(Name = "Comentario")]
    public string? comments { get; set; }

    // Relaciones
    [JsonIgnore]
    public Mentor? mentor { get; set; }

    public int? mentorId { get; set; }

    [JsonIgnore]
    public Project? project { get; set; }

    public int? projectId { get; set; }
}