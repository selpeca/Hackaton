using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Person
{
    public int? id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string? name { get; set; }

    [Display(Name = "Apellido")]
    [MaxLength(100, ErrorMessage = "EL apellido debe ser menor a 100 caracteres")]
    [Required]
    public string? lastName { get; set; }

    [Display(Name = "Fecha de nacimiento")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    public DateTime birthDate { get; set; }

    [Display(Name = "Tipo de documento")]
    public string? typeDocument { get; set; }

    [Display(Name = "Número de documento")]
    public string? document { get; set; }

    [Display(Name = "Nombre completo")]
    public string? fullName => $"{name}  {lastName}";

    [JsonIgnore]
    public ICollection<Participant>? participants { get; set; }

    [JsonIgnore]
    public ICollection<Mentor>? mentor { get; set; }
}