namespace shared.Entities;

public class Mentor
{
    public int Id { get; set; }
    public int PersonId { get; set; }

    // Relaciones
    public Person person { get; set; }

    public ICollection<MentorArea> MentorsArea { get; set; }
    public ICollection<Evaluation> Evaluations { get; set; }
}