using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class People
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
    public DateTime BirthDate { get; set; }

    [Display(Name = "Tipo de documento")]
    public string TypeDocument { get; set; }

    [Display(Name = "Número de documento")]
    public string Document { get; set; }

    [Display(Name = "Nombre completo")]
    public string FullName => $"{Name}  {LastName}";

    public ICollection<Participants> Participants { get; set; }
    public ICollection<Mentors> Mentors { get; set; }
}