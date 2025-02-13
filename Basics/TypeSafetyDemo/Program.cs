namespace TypeSafetyDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Strongly typed variable
        int number = 10;
        Console.WriteLine("Integer value: " + number);

        // Type mismatch example (uncomment to see compile-time error)
        // number = "Hello"; // Error: Cannot implicitly convert type 'string' to 'int'

        // Implicit type conversion (safe)
        double doubleNumber = number;
        Console.WriteLine("Implicit conversion to double: " + doubleNumber);

        // Explicit type conversion (type casting)
        double someDouble = 9.75;
        int truncatedInt = (int)someDouble;
        Console.WriteLine("Explicit conversion (casting) to int: " + truncatedInt);

        // Invalid conversion example (uncomment to see compile-time error)
        // int invalidConversion = someDouble; // Error: Cannot implicitly convert 'double' to 'int'

        // Using var (type inferred at compile-time)
        var inferredInteger = 20;
        Console.WriteLine("Inferred type variable: " + inferredInteger);

        // Dynamic type (runtime type checking, less safe)
        dynamic dynamicVariable = 5;
        Console.WriteLine("Dynamic variable: " + dynamicVariable);
        dynamicVariable = "Now a string!";
        Console.WriteLine("Dynamic variable changed: " + dynamicVariable);

        // Nullable types (safe handling of null values)
        int? nullableInt = null;
        Console.WriteLine("Nullable int: " + nullableInt);

        // Type safety with generics
        SafeList<int> intList = new SafeList<int>();
        intList.Add(42);
        Console.WriteLine("Generic List item: " + intList.Get(0));
    }
}

// Generic class ensuring type safety
class SafeList<T>
{
    private System.Collections.Generic.List<T> list = new System.Collections.Generic.List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public T Get(int index)
    {
        return list[index];
    }
}
