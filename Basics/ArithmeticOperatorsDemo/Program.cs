namespace ArithmeticOperatorsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Arithmetic Operators
        Console.WriteLine("--- Arithmetic Operators ---");

        int a = 10;
        int b = 5;

        Console.WriteLine($"a = {a}, b = {b}");

        Console.WriteLine($"a + b = {a + b}"); // Addition
        Console.WriteLine($"a - b = {a - b}"); // Subtraction
        Console.WriteLine($"a * b = {a * b}"); // Multiplication
        Console.WriteLine($"a / b = {a / b}"); // Division
        Console.WriteLine($"a % b = {a % b}"); // Modulus (remainder)

        double c = 7.0;
        double d = 2.0;
        Console.WriteLine($"c = {c}, d = {d}");
        Console.WriteLine($"c / d = {c / d}"); //Division with doubles

        // Increment and Decrement Operators
        Console.WriteLine("\n--- Increment and Decrement Operators ---");

        int x = 5;
        Console.WriteLine($"Initial x = {x}");

        Console.WriteLine($"x++ (Post-increment): {x++}"); // Post-increment (returns value then increments)
        Console.WriteLine($"x (after post-increment) = {x}");

        Console.WriteLine($"++x (Pre-increment): {++x}"); // Pre-increment (increments then returns value)
        Console.WriteLine($"x (after pre-increment) = {x}");

        int y = 8;
        Console.WriteLine($"Initial y = {y}");

        Console.WriteLine($"y-- (Post-decrement): {y--}"); // Post-decrement
        Console.WriteLine($"y (after post-decrement) = {y}");

        Console.WriteLine($"--y (Pre-decrement): {--y}"); // Pre-decrement
        Console.WriteLine($"y (after pre-decrement) = {y}");

        // Specialized Operations on Integral Types
        Console.WriteLine("\n--- Specialized Operations on Integral Types ---");

        int num1 = 10;
        int num2 = 3;

        Console.WriteLine($"num1 = {num1}, num2 = {num2}");

        // Integer Division (truncates decimal part)
        Console.WriteLine($"Integer Division (num1 / num2): {num1 / num2}");

        // Bitwise Operators (Example)
        int bitwiseA = 5; // 0101 in binary
        int bitwiseB = 3; // 0011 in binary

        Console.WriteLine($"bitwiseA = {bitwiseA}, bitwiseB = {bitwiseB}");
        Console.WriteLine($"bitwiseA & bitwiseB (AND): {bitwiseA & bitwiseB}"); // 0001 (1)
        Console.WriteLine($"bitwiseA | bitwiseB (OR): {bitwiseA | bitwiseB}");  // 0111 (7)
        Console.WriteLine($"bitwiseA ^ bitwiseB (XOR): {bitwiseA ^ bitwiseB}"); // 0110 (6)
        Console.WriteLine($"~bitwiseA (NOT): {~bitwiseA}"); // inverts the bits.
        Console.WriteLine($"bitwiseA << 1 (Left shift): {bitwiseA << 1}"); // 1010 (10)
        Console.WriteLine($"bitwiseA >> 1 (Right shift): {bitwiseA >> 1}"); // 0010 (2)

        //Checked and Unchecked operations
        Console.WriteLine("\n--- Checked and Unchecked Operations ---");

        byte byteMax = byte.MaxValue;
        Console.WriteLine($"byteMax = {byteMax}");

        //Unchecked Context (default)
        byte uncheckedResult = (byte)(byteMax + 1);
        Console.WriteLine($"Unchecked byteMax + 1: {uncheckedResult}"); //Result wraps around.

        //Checked Context
        try
        {
            checked
            {
                byte checkedResult = (byte)(byteMax + 1);
                Console.WriteLine($"Checked byteMax + 1: {checkedResult}");
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Checked byteMax + 1: Overflow Exception: {ex.Message}");
        }

        //Constant overflow check during compilation
        try
        {
            checked
            {
                // shows how constant overflow can be caught at compile time when in a checked context.
                // un-comment below for check
                //const byte constOver = (byte)256;
                //Console.WriteLine($"Const Over: {constOver}");
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Const Over Exception: {ex.Message}");
        }

    }
}

