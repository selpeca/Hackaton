namespace shared.Entities;

public class Evaluation
{
    public int Id { get; set; }
    public int MentorId { get; set; }
    public int ProjectId { get; set; }
    public string Judgment { get; set; }
    public int Score { get; set; }
    public string? Comments { get; set; }

    // Relaciones
    public Mentor Mentor { get; set; }

    public Project Project { get; set; }
}