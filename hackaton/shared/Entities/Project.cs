using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Project
{
    public int id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string? name { get; set; }

    [Display(Name = "Descripción")]
    public string? description { get; set; }

    [Display(Name = "Estado")]
    public string status { get; set; } // por iniciar, en progreso, finalizado

    [Display(Name = "Fecha de entrega")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    public DateTime deliveryDate { get; set; }

    // Relaciones
    [JsonIgnore]
    public Team? team { get; set; }

    public int? teamId { get; set; }

    [JsonIgnore]
    public Hackaton? hackaton { get; set; }

    public int? hackatonId { get; set; }

    [JsonIgnore]
    public ICollection<Evaluation>? evaluations { get; set; }
}