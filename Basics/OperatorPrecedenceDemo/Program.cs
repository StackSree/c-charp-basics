namespace OperatorPrecedenceDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Operator Precedence and Associativity Demo ---");

        // Example 1: Multiplication (*) has higher precedence than Addition (+)
        int result1 = 10 + 5 * 2;
        Console.WriteLine($"10 + 5 * 2 = {result1} (Multiplication first)");

        // Example 2: Using parentheses to change precedence
        int result2 = (10 + 5) * 2;
        Console.WriteLine($"(10 + 5) * 2 = {result2} (Addition first due to parentheses)");

        // Example 3: Left-to-right associativity of arithmetic operators
        int result3 = 100 / 10 * 5; // (100 / 10) * 5 = 10 * 5 = 50
        Console.WriteLine($"100 / 10 * 5 = {result3} (Left-to-right evaluation)");

        // Example 4: Right-to-left associativity of assignment operator
        int a, b;
        a = b = 20; // b = 20 is evaluated first, then a = b
        Console.WriteLine($"a = b = 20 -> a: {a}, b: {b}");

        // Example 5: Logical AND (&&) has higher precedence than Logical OR (||)
        bool boolResult = true || false && false; // false && false -> false, then true || false -> true
        Console.WriteLine($"true || false && false = {boolResult} (&& first, then ||)");

        // Example 6: Conditional (ternary) operator precedence
        int x = 5, y = 10;
        int min = (x < y) ? x : y; // ?: has lower precedence than comparison <
        Console.WriteLine($"(5 < 10) ? 5 : 10 = {min}");
       

        Console.WriteLine("\n--- End of Demo ---");
    }
}
