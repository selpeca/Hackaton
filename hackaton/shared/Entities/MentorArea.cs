using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace shared.Entities;

public class MentorArea
{
    public int id { get; set; }

    [Display(Name = "Area")]
    [MaxLength(100, ErrorMessage = "El nombre del area debe ser menor a 100 caracteres")]
    [Required]
    public string area { get; set; }

    // Relaciones
    [JsonIgnore]
    public Mentor mentor { get; set; }
    public int mentorId { get; set; }
}