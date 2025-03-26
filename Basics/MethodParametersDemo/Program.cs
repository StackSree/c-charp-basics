namespace MethodParametersDemo;

internal class Program
{
    static void Main(string[] args)
    {

        int value = 5;
        Console.WriteLine($"Initial value: {value}");

        PassByValue(value);
        Console.WriteLine($"After PassByValue: {value}");

        PassByRef(ref value);
        Console.WriteLine($"After PassByRef: {value}");

        ReadOnlyRef(in value);
        Console.WriteLine($"After ReadOnlyRef: {value}");

        GetValues(out int x, out int y);
        Console.WriteLine($"After GetValues: x={x}, y={y}");
    }

    static void PassByValue(int x)
    {
        x = 10;
        Console.WriteLine($"Inside PassByValue: {x}");
    }

    static void PassByRef(ref int x)
    {
        x = 10;
        Console.WriteLine($"Inside PassByRef: {x}");
    }

    static void ReadOnlyRef(in int x)
    {
        Console.WriteLine($"Inside ReadOnlyRef: {x}");
    }

    static void GetValues(out int x, out int y)
    {
        x = 10;
        y = 20;
        Console.WriteLine($"Inside GetValues: x={x}, y={y}");
    }
}

