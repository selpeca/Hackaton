using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Participant
{
    public int Id { get; set; }

    [Display(Name = "Profesión")]
    [MaxLength(100, ErrorMessage = "La profesión debe ser menor a 250 caracteres")]
    [Required]
    public string Profession { get; set; }

    public Person? Person { get; set; }

    public int PersonId { get; set; }
}