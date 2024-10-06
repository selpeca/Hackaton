using System.Text.Json.Serialization;

namespace shared.Entities;

public class Mentor
{
    public int id { get; set; }

    // Relaciones
    [JsonIgnore]
    public Person person { get; set; }

    public int personId { get; set; }

    [JsonIgnore]
    public ICollection<MentorArea> mentorsArea { get; set; }

    [JsonIgnore]
    public ICollection<Evaluation> evaluations { get; set; }
}