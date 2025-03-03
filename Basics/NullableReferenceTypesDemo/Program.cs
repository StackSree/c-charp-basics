namespace NullableReferenceTypesDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Enabling Nullable Reference Types:
        // In your .csproj file, add:
        // <Nullable>enable</Nullable>
        // within a <PropertyGroup> tag.

        // Without Nullable Reference Types (traditional behavior):
        string traditionalString = null; // Allowed, but potential runtime error.
        Console.WriteLine($"Traditional String: {traditionalString}"); // Prints "Traditional String: "

        // With Nullable Reference Types enabled:
        string? nullableString = null; // Explicitly allowed to be null.
        // string nonNullableString = null; // Compiler error! Cannot assign null to a non-nullable string.

        if (nullableString == null)
        {
            Console.WriteLine("Nullable String is null.");
        }
        else
        {
            Console.WriteLine($"Nullable String: {nullableString}");
        }

        // Dereferencing a nullable string requires null checks or the null-forgiving operator:
        string lengthString = nullableString?.Length.ToString(); // Safe navigation operator.
        Console.WriteLine($"Length String: {lengthString}");

        // Or using the null-forgiving operator, but it's risky if the value IS null:
        // Compiler warning suppressed. Runtime exception if null.
        // Hence commented, un-comment while demo or studying
        // string potentiallyDangerousLength = nullableString!.Length.ToString(); 

        // Example with a class:
        Person? person = null;
        if (person == null)
        {
            Console.WriteLine("Person object is null");
        }

        Person person2 = new Person();
        person2.Name = "Alice";
        Console.WriteLine($"Person2's name: {person2.Name}");

        Person person3 = new Person();
        //person3.Name; // Compiler Warning: non-nullable property 'Name' is uninitialized.
        person3.Name = null; //Allowed, because the compiler knows that the name is a string, and strings are nullable.

        Person? person4 = new Person();
        person4 = null;
        if (person4?.Name == null)
        {
            Console.WriteLine("Person4's name is null, or Person4 is null.");
        }
    }
}

public class Person
{
    // Initializes the property.
   // Compiler Warning: non-nullable property 'Name' is uninitialized.
    public string Name { get; set; } = "";

}
