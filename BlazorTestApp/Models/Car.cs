namespace BlazorTestApp.Models;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CurrentBoost { get; set; }
    public HitboxType HitboxType { get; set; }
}


public enum HitboxType
{
    Octane,
    Dominus,
    Plank,
    Hybrid,
    Merc,
}
