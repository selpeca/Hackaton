using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class Awards
{
    public int Id { get; set; }
    public int HackatonId { get; set; }
    public string Position { get; set; }
    public string Prize { get; set; }

    // Relaciones
    public Hackaton Hackaton { get; set; }
}