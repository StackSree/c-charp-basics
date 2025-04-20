namespace ClassModifierDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Demonstrate public class
        PublicClassDemo publicObj = new PublicClassDemo();
        publicObj.DisplayMessage();
        Console.WriteLine();

        // Demonstrate internal class (can be accessed within the same assembly)
        InternalClassDemo internalObj = new InternalClassDemo();
        internalObj.RevealSecret();
        Console.WriteLine();

        // Demonstrate abstract and derived class
        Circle circle = new Circle(5);
        circle.Display();
        Console.WriteLine();

        // Demonstrate sealed class
        Console.WriteLine($"FinalUtility Current Date: {FinalUtility.GetCurrentDate()}");
        Console.WriteLine();

        // Demonstrate static class
        string original = "hello";
        string reversed = StringHelper.Reverse(original);
        Console.WriteLine($"Original: {original}, Reversed: {reversed}");
        Console.WriteLine();

        // Demonstrate partial class
        UserProfile user = new UserProfile
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30,
            Email = "john.doe@example.com"
        };
        Console.WriteLine($"UserProfile Full Name: {user.GetFullName()}");
        user.SendWelcomeEmail();
        Console.WriteLine();

        Console.ReadKey();
    }
}

// Public class
public class PublicClassDemo
{
    public string Message = "This is a public class.";

    public void DisplayMessage()
    {
        Console.WriteLine($"PublicClassDemo: {Message}");
    }
}

// Internal class
internal class InternalClassDemo
{
    internal string Secret = "This is an internal secret.";

    internal void RevealSecret()
    {
        Console.WriteLine($"InternalClassDemo: {Secret}");
    }
}

// Abstract class
public abstract class Shape
{
    public abstract double Area();

    public void Display()
    {
        Console.WriteLine($"Shape Area: {Area()}");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
// Sealed class
public sealed class FinalUtility
{
    public static string GetCurrentDate()
    {
        return DateTime.Now.ToShortDateString();
    }
}

// Static class
public static class StringHelper
{
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

// Partial class (File1.cs - conceptually within the same file here)
public partial class UserProfile
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

// Partial class (File2.cs - conceptually within the same file here)
public partial class UserProfile
{
    public int Age { get; set; }
    public string Email { get; set; }

    public void SendWelcomeEmail()
    {
        Console.WriteLine($"UserProfile: Welcome, {GetFullName()} ({Email})!");
    }
}

// Note: The 'unsafe' class requires the /unsafe compiler option
// and is not included in this basic console app demonstration
// to keep it straightforward.
