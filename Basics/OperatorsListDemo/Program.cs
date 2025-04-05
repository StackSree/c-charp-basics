namespace OperatorsListDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== C# Operator Demo ==");
        OperatorExamples.PrimaryOperators();
        OperatorExamples.UnaryOperators();
        OperatorExamples.MultiplicativeAdditive();
        OperatorExamples.ShiftAndRelational();
        OperatorExamples.EqualityAndBitwise();
        OperatorExamples.ConditionalOperators();
        OperatorExamples.AssignmentAndLambda();
    }
}

public class OperatorExamples
{
    public static void PrimaryOperators()
    {
        Console.WriteLine("\n-- Primary Operators --");
        string str = "hello";
        Console.WriteLine(str.Length);          // .
        Console.WriteLine(str?.Length);         // ?.
        Console.WriteLine(str ?? "default");    // ??
        Console.WriteLine(typeof(int));         // typeof
        Console.WriteLine(nameof(str));         // nameof
        Console.WriteLine(default(char));       // default
        Console.WriteLine(checked(10 + 20));    // checked
        Console.WriteLine(unchecked(int.MaxValue + 1)); // unchecked (may wrap)
    }

    public static void UnaryOperators()
    {
        Console.WriteLine("\n-- Unary Operators --");
        int x = 5;
        Console.WriteLine(+x);   // Positive
        Console.WriteLine(-x);   // Negative
        Console.WriteLine(!false); // Not
        Console.WriteLine(~x);   // Bitwise NOT
        Console.WriteLine(++x);  // Pre-increment
        Console.WriteLine(--x);  // Pre-decrement
        Console.WriteLine((double)x); // Cast
        Console.WriteLine(^1);   // Index from end (C# 8+)
    }

    public static void MultiplicativeAdditive()
    {
        Console.WriteLine("\n-- Multiplicative/Additive --");
        int a = 10, b = 3;
        Console.WriteLine(a * b);  // Multiply
        Console.WriteLine(a / b);  // Divide
        Console.WriteLine(a % b);  // Modulus
        Console.WriteLine(a + b);  // Add
        Console.WriteLine(a - b);  // Subtract
    }

    public static void ShiftAndRelational()
    {
        Console.WriteLine("\n-- Shift/Relational --");
        int a = 4;
        Console.WriteLine(a << 1); // Left shift
        Console.WriteLine(a >> 1); // Right shift
        Console.WriteLine(a < 10); // Less than
        Console.WriteLine(a >= 2); // Greater or equal
        Console.WriteLine(5 is int); // is
        object obj = "string";
        Console.WriteLine(obj as string); // as
    }

    public static void EqualityAndBitwise()
    {
        Console.WriteLine("\n-- Equality/Bitwise --");
        int a = 5, b = 5, c = 3;
        Console.WriteLine(a == b); // Equals
        Console.WriteLine(a != c); // Not equals
        Console.WriteLine(a & c);  // Bitwise AND
        Console.WriteLine(a | c);  // Bitwise OR
        Console.WriteLine(a ^ c);  // Bitwise XOR
    }

    public static void ConditionalOperators()
    {
        Console.WriteLine("\n-- Conditional --");
        bool cond = true;
        Console.WriteLine(cond && false); // AND
        Console.WriteLine(cond || false); // OR
        int? val = null;
        Console.WriteLine(val ?? 42); // Null coalescing
        Console.WriteLine(cond ? "Yes" : "No"); // Ternary
    }

    public static void AssignmentAndLambda()
    {
        Console.WriteLine("\n-- Assignment & Lambda --");
        int x = 5;
        x += 2;
        x *= 2;
        Console.WriteLine(x); // Compound assignments

        Func<int, int> square = n => n * n;
        Console.WriteLine(square(5)); // Lambda

        var point = new Point(1, 2);
        var moved = point with { X = 5 };
        Console.WriteLine(moved); // 'with' expression

        int number = 1;
        string message = number switch
        {
            1 => "One",
            _ => "Other"
        };
        Console.WriteLine(message); // Switch expression
    }
}

public record Point(int X, int Y);

// Example of operator overloading
public class CustomNumber
{
    public int Value { get; set; }

    public CustomNumber(int val) => Value = val;

    public static CustomNumber operator +(CustomNumber a, CustomNumber b) =>
        new CustomNumber(a.Value + b.Value);

    public override string ToString() => Value.ToString();
}
