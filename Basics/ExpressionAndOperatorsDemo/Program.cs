namespace ExpressionAndOperatorsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Primary Expressions
        int number = 42;   // Literal Expression
        Console.WriteLine("Literal Expression: " + number);

        int result = (5 + 3) * 2;  // Parenthesized Expression
        Console.WriteLine("Parenthesized Expression: " + result);

        string message = "Hello, World!";
        Console.WriteLine("Member Access Expression: " + message.Length); // Accessing property of string

        int[] numbers = { 10, 20, 30 };
        Console.WriteLine("Element Access Expression: " + numbers[1]); // Accessing array element

        Console.WriteLine("Invocation Expression: " + Add(7, 3)); // Calling a method

        // Void Expression
        PrintMessage(); // Calls a void method

        // Assignment Expressions
        int x;
        x = 10;  // Simple Assignment
        Console.WriteLine("Assignment Expression: " + x);

        x += 5;  // Compound Assignment (x = x + 5)
        Console.WriteLine("Compound Assignment Expression: " + x);

        int a, b, c;
        a = b = c = 50; // Chained Assignment
        Console.WriteLine("Chained Assignment Expression: a = " + a + ", b = " + b + ", c = " + c);
    }

    // A method with a void return type (Void Expression)
    static void PrintMessage()
    {
        Console.WriteLine("Hello from Void Expression!");
    }

    // A method returning an integer
    static int Add(int a, int b)
    {
        return a + b;
    }
}
