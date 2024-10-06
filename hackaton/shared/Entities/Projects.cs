using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class Projects
{
    public int Id { get; set; }
    public int TeamId { get; set; }
    public int HackatonId { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string Name { get; set; }

    public string Description { get; set; }
    public string Status { get; set; } // por iniciar, en progreso, finalizado
    public DateTime DeliveryDate { get; set; }

    // Relaciones
    public Teams Team { get; set; }

    public Hackaton Hackaton { get; set; }
    public ICollection<Evaluations> Evaluations { get; set; }
}