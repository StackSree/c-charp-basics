namespace ValueTypesVsReferenceTypesDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Value Types (e.g., int, bool, struct)
        Console.WriteLine("--- Value Types ---");

        int num1 = 10;
        int num2 = num1; // Copy of the value

        Console.WriteLine($"num1: {num1}, num2: {num2}"); // Output: num1: 10, num2: 10

        num2 = 20; // Modifying num2 does not affect num1

        Console.WriteLine($"num1: {num1}, num2: {num2}"); // Output: num1: 10, num2: 20

        // Struct Example
        Point p1 = new Point(1, 2);
        Point p2 = p1; // Copy of the struct

        Console.WriteLine($"p1: ({p1.X}, {p1.Y}), p2: ({p2.X}, {p2.Y})"); // Output: p1: (1, 2), p2: (1, 2)

        p2.X = 5;

        Console.WriteLine($"p1: ({p1.X}, {p1.Y}), p2: ({p2.X}, {p2.Y})"); // Output: p1: (1, 2), p2: (5, 2)

        // Reference Types (e.g., class, string, arrays, lists)
        Console.WriteLine("\n--- Reference Types ---");

        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1; // arr2 points to the same memory location as arr1

        Console.WriteLine($"arr1: [{string.Join(", ", arr1)}], arr2: [{string.Join(", ", arr2)}]"); // Output: arr1: [1, 2, 3], arr2: [1, 2, 3]

        arr2[0] = 100; // Modifying arr2 modifies arr1

        Console.WriteLine($"arr1: [{string.Join(", ", arr1)}], arr2: [{string.Join(", ", arr2)}]"); // Output: arr1: [100, 2, 3], arr2: [100, 2, 3]

        // Class Example
        Person person1 = new Person("Alice");
        Person person2 = person1; // person2 points to the same object as person1

        Console.WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}"); // Output: person1.Name: Alice, person2.Name: Alice

        person2.Name = "Bob"; // Modifying person2 modifies person1

        Console.WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}"); // Output: person1.Name: Bob, person2.Name: Bob

        // String Example (Reference Type but behaves like a value type)
        string str1 = "Hello";
        string str2 = str1;

        Console.WriteLine($"str1: {str1}, str2: {str2}"); // Output: str1: Hello, str2: Hello

        str2 = "World";

        Console.WriteLine($"str1: {str1}, str2: {str2}"); // Output: str1: Hello, str2: World

        // List Example
        List<int> list1 = new List<int>() { 1, 2, 3 };
        List<int> list2 = list1;

        Console.WriteLine($"list1: [{string.Join(", ", list1)}], list2: [{string.Join(", ", list2)}]");

        list2.Add(4);

        Console.WriteLine($"list1: [{string.Join(", ", list1)}], list2: [{string.Join(", ", list2)}]");
    }
}

// Struct Definition
public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

// Class Definition
public class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}
