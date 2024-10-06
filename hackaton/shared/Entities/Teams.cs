using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class Teams
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string Name { get; set; }

    public int NumMembers { get; set; }

    // Relaciones
    public ICollection<TeamMembers> TeamMembers { get; set; }

    public ICollection<ExperienceTeam> ExperienceTeams { get; set; }
    public ICollection<Projects> Projects { get; set; }
}