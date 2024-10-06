using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class Hackaton
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string Name { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Subject { get; set; }
    public int OwnerId { get; set; }

    // Relaciones
    public ICollection<Projects> Projects { get; set; }

    public ICollection<Awards> Awards { get; set; }
}