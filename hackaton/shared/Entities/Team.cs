using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Team
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Numero de miembros")]
    public int NumMembers { get; set; }

    // Relaciones
    [JsonIgnore]
    public ICollection<TeamMember> TeamMembers { get; set; }

    [JsonIgnore]
    public ICollection<ExperienceTeam> ExperienceTeams { get; set; }

    [JsonIgnore]
    public ICollection<Project> Projects { get; set; }
}