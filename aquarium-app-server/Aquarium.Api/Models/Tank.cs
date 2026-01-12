using System;
using Aquarium.Api.Models.Enums;

namespace Aquarium.Api.Models;

public class Tank
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public AquariumType Type { get; set; }
    public double VolumeLiters { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime EndedAt { get; set; }

    // Navigation properties
    public ICollection<Fish> Fishes { get; set; } = new List<Fish>();
    public ICollection<Plant> Plants { get; set; } = new List<Plant>();
    public ICollection<Equipment> Equipments { get; set; } = new List<Equipment>();
    public ICollection<WaterTest> WaterTests { get; set; } = new List<WaterTest>();
    public ICollection<FeedingSchedule> FeedingSchedules { get; set; } = new List<FeedingSchedule>();
    
}
