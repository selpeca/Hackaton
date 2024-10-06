﻿using System.ComponentModel.DataAnnotations;

namespace shared.Entities;

public class ExperienceTeam
{
    public int Id { get; set; }
    public int TeamId { get; set; }
    public string Description { get; set; }
    public TimeSpan Time { get; set; }

    // Relaciones
    public Teams Team { get; set; }
}