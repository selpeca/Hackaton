using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Evaluation
{
    public int Id { get; set; }

    [Display(Name = "Criterio")]
    [Required]
    public string Judgment { get; set; }

    [Display(Name = "Puntuación")]
    [Required]
    public int Score { get; set; }

    [Display(Name = "Comentario")]
    public string? Comments { get; set; }

    // Relaciones
    [JsonIgnore]
    public Mentor Mentor { get; set; }

    public int MentorId { get; set; }

    [JsonIgnore]
    public Project Project { get; set; }

    public int ProjectId { get; set; }
}