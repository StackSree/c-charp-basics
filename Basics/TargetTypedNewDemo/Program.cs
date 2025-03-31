using System.Text;

namespace TargetTypedNewDemo;

internal class Program
{

    // Field initialized using target-typed new in the constructor
    private StringBuilder fieldBuilder;

    public void TargetTypedNew(string initialValue)
    {
        fieldBuilder = new(initialValue); // Target type is StringBuilder (from field declaration)
        Console.WriteLine($"Field Builder (from constructor): {fieldBuilder}");
    }

    public static void MyMethod(StringBuilder sb)
    {
        Console.WriteLine($"Inside MyMethod: {sb}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating target-typed new expressions:");

        // Local variable declaration and initialization
        StringBuilder sb1 = new(); // Target type is StringBuilder (from variable declaration)
        Console.WriteLine($"sb1: {sb1}");

        StringBuilder sb2 = new("Test"); // Target type is StringBuilder (from variable declaration)
        Console.WriteLine($"sb2: {sb2}");

        // Equivalent verbose syntax:
        StringBuilder sb3 = new StringBuilder();
        Console.WriteLine($"sb3 (verbose): {sb3}");

        StringBuilder sb4 = new StringBuilder("Another Test");
        Console.WriteLine($"sb4 (verbose): {sb4}");

        Console.WriteLine("\nDemonstrating target-typed new in a constructor:");
        Program demo = new Program();
        Console.WriteLine($"Field Builder value: {demo.fieldBuilder}");

        Console.WriteLine("\nDemonstrating target-typed new as a method argument:");
        MyMethod(new("Argument String")); // Target type is StringBuilder (from MyMethod parameter)

        // Equivalent verbose syntax:
        MyMethod(new StringBuilder("Verbose Argument"));

    }
}