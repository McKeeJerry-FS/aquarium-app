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
}
