namespace SimpleAppWithAbstractClassDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a name:");
        string userName = Console.ReadLine();
        Console.WriteLine();

        FormalGreeter formal = new FormalGreeter(userName);
        Console.WriteLine("Formal Greeting:");
        formal.PerformGreeting();
        Console.WriteLine();

        CasualGreeter casual = new CasualGreeter(userName);
        Console.WriteLine("Casual Greeting:");
        casual.PerformGreeting();
        Console.WriteLine();

        // You can also work with the abstract base class type (polymorphism)
        Greeter anotherFormal = new FormalGreeter("Professor Higgins");
        Console.WriteLine("Another Formal Greeting:");
        anotherFormal.PerformGreeting();
        Console.WriteLine();

        Greeter anotherCasual = new CasualGreeter("Buddy");
        Console.WriteLine("Another Casual Greeting:");
        anotherCasual.PerformGreeting();
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

// Abstract base class for greetings
public abstract class Greeter
{
    public string Name { get; protected set; }

    public Greeter(string name)
    {
        Name = name;
    }

    // Abstract method to generate a greeting
    public abstract string Greet();

    // Concrete (non-abstract) method that uses the abstract Greet method
    public void PerformGreeting()
    {
        Console.WriteLine(Greet());
    }
}

// Concrete class for a formal greeter
public class FormalGreeter : Greeter
{
    public FormalGreeter(string name) : base(name)
    {
    }

    public override string Greet()
    {
        return $"Greetings, esteemed {Name}. It is a pleasure to make your acquaintance.";
    }
}

// Concrete class for a casual greeter
public class CasualGreeter : Greeter
{
    public CasualGreeter(string name) : base(name)
    {
    }

    public override string Greet()
    {
        return $"Hey {Name}! What's up?";
    }
}
