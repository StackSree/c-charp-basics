namespace MethodWithPartialModifier;

internal class Program
{
    static void Main(string[] args)
    {
        User user = new User { Name = "Alice", Age = 30 };
        user.UpdateAge(31);        
    }
}

public partial class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void UpdateAge(int newAge)
    {
        Age = newAge;
        Log($"Age updated to {Age}");
    }

    // Partial method declaration
    partial void Log(string message);
}

public partial class User
{
    // Optional implementation of the Log method
    partial void Log(string message)
    {
        Console.WriteLine($"[User Log] {DateTime.Now}: {message}");
        // You could also write to a file, database, etc., here.
    }
}
