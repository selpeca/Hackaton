using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Hackaton
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Fecha de inicio")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime StartDate { get; set; }

    [Display(Name = "Fecha de finalización")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime EndDate { get; set; }

    [Display(Name = "Tema")]
    [Required]
    public string Subject { get; set; }

    [JsonIgnore]
    public Person? Owner { get; set; }

    public int OwnerId { get; set; }

    // Relaciones
    public ICollection<Project> Projects { get; set; }

    public ICollection<Award> Awards { get; set; }
}