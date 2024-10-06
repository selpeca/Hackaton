using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class MentorArea
{
    public int Id { get; set; }

    [Display(Name = "Area")]
    [MaxLength(100, ErrorMessage = "El nombre del area debe ser menor a 100 caracteres")]
    [Required]
    public string Area { get; set; }

    // Relaciones
    [JsonIgnore]
    public Mentor Mentor { get; set; }

    public int MentorId { get; set; }
}