namespace TypeTaxonomyDemo;

internal class Program
{
    // Enumeration type (value type)
    public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    // Structure type (value type)
    public struct Point
    {
        public int X;
        public int Y;
    }

    // Class type (reference type)
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // Interface type (reference type)
    public interface IPrintable
    {
        void Print();
    }

    // Class implementing the interface
    public class Document : IPrintable
    {
        public string Content;

        public Document(string content)
        {
            Content = content;
        }

        public void Print()
        {
            Console.WriteLine($"Document Content: {Content}");
        }
    }

    // Delegate type (reference type)
    public delegate void MyDelegate(string message);

    static void Main(string[] args)
    {
        // Value types (simple types)
        int myInt = 10;
        double myDouble = 3.14;
        bool myBool = true;
        char myChar = 'A';
        decimal myDecimal = 100.50m;
        byte myByte = 255;

        Console.WriteLine($"int: {myInt}, double: {myDouble}, bool: {myBool}, char: {myChar}, decimal: {myDecimal}, byte: {myByte}");

        // Enumeration type
        Days today = Days.Wednesday;
        Console.WriteLine($"Today is: {today}");

        // Structure type
        Point myPoint;
        myPoint.X = 5;
        myPoint.Y = 10;
        Console.WriteLine($"Point: ({myPoint.X}, {myPoint.Y})");

        // Reference types (class)
        Person person1 = new Person("Alice", 30);
        Person person2 = person1; // Both variables refer to the same object
        person2.Name = "Bob"; // Changes person1.Name as well

        Console.WriteLine($"Person 1 Name: {person1.Name}, Person 2 Name: {person2.Name}");

        // Reference types (interface)
        Document myDocument = new Document("This is a test document.");
        myDocument.Print();

        // Reference types (array)
        int[] myArray = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Array: {string.Join(", ", myArray)}");

        // Reference types (string)
        string myString = "Hello, C#!";
        Console.WriteLine($"String: {myString}");

        // Reference types (object)
        object myObject = myInt; // Boxing (value type to reference type)
        int unboxedInt = (int)myObject; // Unboxing (reference type to value type)
        Console.WriteLine($"Object: {myObject}, Unboxed Int: {unboxedInt}");

        // Delegate example
        MyDelegate myDelegate = PrintMessage;
        myDelegate("Delegate message!");

        // Unsafe example.
        // Go to the Build tab.
        // Check the box labeled Allow unsafe code.
        // Save your changes.
        unsafe
        {
            int num = 42;
            int* ptr = &num;
            Console.WriteLine($"Unsafe pointer: {*ptr}");
        }
    }

    public static void PrintMessage(string message)
    {
        Console.WriteLine($"Message from delegate: {message}");
    }
}
