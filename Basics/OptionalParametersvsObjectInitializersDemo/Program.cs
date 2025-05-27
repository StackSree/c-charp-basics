namespace OptionalParametersvsObjectInitializersDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Using constructor with optional parameters
        Bunny b1 = new Bunny(name: "Bo", likesCarrots: true);
        Console.WriteLine($"Bunny b1: {b1.Name}, LikesCarrots: {b1.LikesCarrots}, LikesHumans: {b1.LikesHumans}");

        // Using object initializer with init-only properties (C# 9+)
        BunnyWithInitOnly b2 = new BunnyWithInitOnly
        {
            Name = "Luna",
            LikesHumans = true
        };
        Console.WriteLine($"Bunny b2: {b2.Name}, LikesCarrots: {b2.LikesCarrots}, LikesHumans: {b2.LikesHumans}");
    }
}
public class Bunny
{
    // Read-only properties (with init only setter - C# 9+)
    public string Name { get; init; }
    public bool LikesCarrots { get; init; }
    public bool LikesHumans { get; init; }

    // Constructor with one mandatory and two optional parameters
    public Bunny(string name, bool likesCarrots = false, bool likesHumans = false)
    {
        Name = name;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }
}

public class BunnyWithInitOnly
{
    // Using init-only setters and object initializers (no constructor needed)
    public string Name { get; init; }
    public bool LikesCarrots { get; init; }
    public bool LikesHumans { get; init; }
}