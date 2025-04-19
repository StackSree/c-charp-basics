namespace SimpleClassDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Create an instance of MyClass
        MyClass instance = new MyClass();

        // Access public field
        Console.WriteLine($"Public Field: {instance.publicField}");

        // Access private field using a public method
        Console.WriteLine($"Private Field (via method): {instance.GetPrivateFieldValue()}");

        // Attempting to access private field directly would cause a compile-time error
        // Console.WriteLine(instance._privateField);

        // Access read-only field
        Console.WriteLine($"Creation Time: {instance.creationTime}");

        // Attempting to modify a read-only field outside the constructor would cause a compile-time error
        // instance.creationTime = DateTime.MinValue;

        // Access static read-only field
        Console.WriteLine($"Temporary Directory: {MyClass.TempDirectory}");

        // Access multiple fields declared together
        Console.WriteLine($"Number of Legs: {instance.numberOfLegs}, Number of Wings: {instance.numberOfWings}");

        // Modify the public field
        instance.SetPublicFieldValue("The public field has been updated.");
        Console.WriteLine($"Updated Public Field: {instance.publicField}");
    }
}

// Simple class declaration
class MyClass
{
    // Public field
    public string publicField = "This is a public field.";

    // Private field (using the underscore convention)
    private int _privateField = 42;

    // Read-only field (initialized in declaration)
    public readonly DateTime creationTime = DateTime.Now;

    // Static read-only field (initialized using a method call)
    public static readonly string TempDirectory = System.IO.Path.GetTempPath();

    // Multiple fields declared together
    public int numberOfLegs = 4, numberOfWings = 2;

    // Constructor
    public MyClass()
    {
        // Can assign a value to a read-only field within the constructor
        // creationTime = DateTime.Now.AddDays(1); // This would cause a compile-time error

        Console.WriteLine("MyClass instance created.");
    }

    // Method to access the private field
    public int GetPrivateFieldValue()
    {
        return _privateField;
    }

    // Method to modify the public field
    public void SetPublicFieldValue(string newValue)
    {
        publicField = newValue;
    }
}



