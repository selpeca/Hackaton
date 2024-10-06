namespace shared.Entities;

public class Evaluations
{
    public int Id { get; set; }
    public int MentorId { get; set; }
    public int ProjectId { get; set; }
    public string Judgment { get; set; }
    public decimal Score { get; set; }
    public string Comments { get; set; }

    // Relaciones
    public Mentor Mentor { get; set; }

    public Projects Project { get; set; }
}