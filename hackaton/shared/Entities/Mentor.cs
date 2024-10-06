namespace shared.Entities;

public class Mentor
{
    public int Id { get; set; }
    public int PersonId { get; set; }

    // Relaciones
    public People People { get; set; }

    public ICollection<MentorArea> MentorAreas { get; set; }
    public ICollection<Evaluations> Evaluations { get; set; }
}