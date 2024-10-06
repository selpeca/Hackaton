using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Project
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Descripción")]
    public string? Description { get; set; }

    [Display(Name = "Estado")]
    public string Status { get; set; } // por iniciar, en progreso, finalizado

    [Display(Name = "Fecha de entrega")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    public DateTime DeliveryDate { get; set; }

    // Relaciones
    [JsonIgnore]
    public Team Team { get; set; }

    public int TeamId { get; set; }

    [JsonIgnore]
    public Hackaton Hackaton { get; set; }

    public int HackatonId { get; set; }

    [JsonIgnore]
    public ICollection<Evaluation> Evaluations { get; set; }
}