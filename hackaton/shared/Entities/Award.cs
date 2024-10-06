using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Award
{
    public int Id { get; set; }

    [Display(Name = "Posición")]
    [Required]
    public int Position { get; set; }

    [Display(Name = "Premio")]
    [Required]
    public string Prize { get; set; }

    // Relaciones
    [JsonIgnore]
    public Hackaton Hackaton { get; set; }

    public int HackatonId { get; set; }
}