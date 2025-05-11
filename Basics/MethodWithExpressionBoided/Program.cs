namespace MethodWithExpressionBoided;

internal class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator(5);

        Console.WriteLine($"Addition: 5 + 3 = {calc.Add(5, 3)}");
        Console.WriteLine($"Subtraction: 10 - 4 = {calc.Subtract(10, 4)}");
        Console.WriteLine($"Description: {calc.OperationDescription}");
        Console.WriteLine($"Value (doubled): {calc.Value}");
        calc.Value = 10;
        Console.WriteLine($"New Value (doubled): {calc.Value}");
        Console.WriteLine($"Message at index 1: {calc[1]}");
    }
}

public class Calculator
{
    // Expression-bodied method for addition
    public int Add(int a, int b) => a + b;

    // Expression-bodied method for subtraction
    public int Subtract(int a, int b) => a - b;

    // Expression-bodied read-only property
    public string OperationDescription => "This class performs basic arithmetic.";

    // Expression-bodied property with a getter (equivalent to auto-implemented property with extra logic)
    private int _value;
    public int Value
    {
        get => _value * 2;
        set => _value = value; // Note: Expression-bodied setters are also possible in C# 7.0+
    }

    // Expression-bodied constructor (less common but possible for simple initialization)
    public Calculator(int initialValue) => _value = initialValue;

    // Expression-bodied finalizer (discouraged for complex logic, but syntactically possible)
    ~Calculator() => Console.WriteLine("Calculator object is being finalized.");

    // Expression-bodied indexer (getter only in this example)
    private readonly string[] _messages = { "Hello", "World", "C#" };
    public string this[int index] => _messages[index];
}