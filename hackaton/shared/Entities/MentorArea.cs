namespace shared.Entities;

public class MentorArea
{
    public int? Id { get; set; }
    public int? MentorId { get; set; }
    public string? Area { get; set; }

    // Relaciones
    public Mentor? Mentor { get; set; }
}