using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Participant
{
    public int? id { get; set; }

    [Display(Name = "Profesión")]
    [MaxLength(250, ErrorMessage = "La profesión debe ser menor a 250 caracteres")]
    [Required]
    public string? profession { get; set; }

    [JsonIgnore]
    public Person? person { get; set; }
    public int? personId { get; set; }
}