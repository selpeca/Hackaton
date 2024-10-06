using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Team
{
    public int? id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string? name { get; set; }

    [Display(Name = "Numero de miembros")]
    public int? numMembers { get; set; }

    // Relaciones
    [JsonIgnore]
    public ICollection<TeamMember>? teamMembers { get; set; }
    
    [JsonIgnore]
    public ICollection<Project>? projects { get; set; }
}