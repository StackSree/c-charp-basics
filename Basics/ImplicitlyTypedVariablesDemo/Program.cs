using System.Text;

namespace ImplicitlyTypedVariablesDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Demonstrating var with different initialization expressions
        var message = "hello"; // Compiler infers string
        var builder = new StringBuilder(); // Compiler infers System.Text.StringBuilder
        var pi = (float)Math.PI; // Compiler infers float

        Console.WriteLine($"message is of type: {message.GetType()}, value: {message}");
        Console.WriteLine($"builder is of type: {builder.GetType()}, value: {builder}");
        Console.WriteLine($"pi is of type: {pi.GetType()}, value: {pi}");

        Console.WriteLine("\nAttempting to assign a different type to a var variable:");
        var number = 5; // Compiler infers int
        Console.WriteLine($"number is of type: {number.GetType()}, value: {number}");

        // The following line would cause a compile-time error:
        // number = "hello"; 

        Console.WriteLine("\nDemonstrating potential readability issue with var:");
        Random r = new Random();
        var randomNumber = r.Next(); // What type is randomNumber without looking at r.Next()?
        Console.WriteLine($"randomNumber is of type: {randomNumber.GetType()}, value: {randomNumber}");

        // It's clear that r.Next() returns an int, but in more complex scenarios,
        // the type might not be immediately obvious from the initialization expression.
    }
}
