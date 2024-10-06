using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Award
{
    public int? id { get; set; }

    [Display(Name = "Posición")]
    [Required]
    public int? position { get; set; }

    [Display(Name = "Premio")]
    [Required]
    public string? prize { get; set; }
    

    // Relaciones
    [JsonIgnore]
    public Hackaton? hackaton { get; set; }
    public int? hackatonId { get; set; }

}