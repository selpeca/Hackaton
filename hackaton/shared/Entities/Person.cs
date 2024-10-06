using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class Person
{
    public int Id { get; set; }

    [Display(Name = "Nombre")]
    [MaxLength(100, ErrorMessage = "EL nombre debe ser menor a 100 caracteres")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Apellido")]
    [MaxLength(100, ErrorMessage = "EL apellido debe ser menor a 100 caracteres")]
    [Required]
    public string LastName { get; set; }

    [Display(Name = "Fecha de nacimiento")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    public DateTime BirthDate { get; set; }

    [Display(Name = "Tipo de documento")]
    public string? TypeDocument { get; set; }

    [Display(Name = "Número de documento")]
    public string? Document { get; set; }

    [Display(Name = "Nombre completo")]
    public string FullName => $"{Name}  {LastName}";

    [JsonIgnore]
    public ICollection<Participant>? Participants { get; set; }

    [JsonIgnore]
    public ICollection<Mentor>? Mentor { get; set; }
}