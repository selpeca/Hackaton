using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class Participants
{
    public int Id { get; set; }

    [Display(Name = "Profesión")]
    [MaxLength(100, ErrorMessage = "La profesión debe ser menor a 250 caracteres")]
    [Required]
    public string Profession { get; set; } = null!;

    public int PersonId { get; set; }
    public People People { get; set; } = null!;
}