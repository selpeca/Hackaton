using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Hackaton
{
    public int? id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string? name { get; set; }

    [Display(Name = "Fecha de inicio")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime? startDate { get; set; }

    [Display(Name = "Fecha de finalización")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime? endDate { get; set; }

    [Display(Name = "Tema")]
    [Required]

    public int? projectId { get; set; }

    [JsonIgnore]
    public Person? owner { get; set; }

    public int? ownerId { get; set; }

    // Relaciones
    public ICollection<Project>? Projects { get; set; }
    
    public ICollection<Award>? Awards { get; set; }
    
}