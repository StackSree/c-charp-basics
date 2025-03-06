namespace NumericLiteralsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Can insert an underscore anywhere within a numeric literal to make it more readable:
        var underscoreInt = 0b1010_1011_1100_1101_1110_1111;
        Console.WriteLine($"Underscore : {underscoreInt}");

        //If the literal contains a decimal point or the exponential symbol (E), it is a double.
        double millionWithExponential = 1E06;
        Console.WriteLine($"Million With Exponential : {millionWithExponential}");

        // Integer Literals
        int decimalInt = 123;       // Decimal (base 10)
        int hexadecimalInt = 0x7B;   // Hexadecimal (base 16)
        int binaryInt = 0b01111011;  // Binary (base 2)
        long longInt = 1234567890123456789L; // Long literal (L suffix)
        uint unsignedInt = 4294967295U; // Unsigned int literal (U suffix)
        ulong unsignedLongInt = 18446744073709551615UL; // Unsigned long literal (UL suffix)

        Console.WriteLine($"Decimal: {decimalInt}");
        Console.WriteLine($"Hexadecimal: {hexadecimalInt}");
        Console.WriteLine($"Binary: {binaryInt}");
        Console.WriteLine($"Long: {longInt}");
        Console.WriteLine($"Unsigned Int: {unsignedInt}");
        Console.WriteLine($"Unsigned Long: {unsignedLongInt}");

        // Floating-Point Literals
        double doubleLiteral = 123.45;     // Double literal (default)
        float floatLiteral = 123.45f;      // Float literal (f suffix)
        decimal decimalLiteral = 123.45m;  // Decimal literal (m suffix)
        double scientificDouble = 1.23e2;   // Scientific notation

        Console.WriteLine($"Double: {doubleLiteral}");
        Console.WriteLine($"Float: {floatLiteral}");
        Console.WriteLine($"Decimal: {decimalLiteral}");
        Console.WriteLine($"Scientific Double: {scientificDouble}");

        // Numeric Literal Type Inference
        var inferredInt = 100;     // Inferred as int
        var inferredDouble = 100.5;  // Inferred as double
        var inferredDecimal = 100.5m; // Inferred as decimal

        Console.WriteLine($"Inferred Int: {inferredInt.GetType()} - {inferredInt}");
        Console.WriteLine($"Inferred Double: {inferredDouble.GetType()} - {inferredDouble}");
        Console.WriteLine($"Inferred Decimal: {inferredDecimal.GetType()} - {inferredDecimal}");

        // Digit Separators
        int largeNumber = 1_000_000;
        double largeDouble = 1_234.567_89;

        Console.WriteLine($"Large Number: {largeNumber}");
        Console.WriteLine($"Large Double: {largeDouble}");

        // Local function to show type inference on arithmetic operations
        void ShowArithmeticInference()
        {
            var result1 = 10 / 3; // Integer division, result is int
            var result2 = 10.0 / 3; // Double division, result is double
            var result3 = 10 / 3.0; // Double division, result is double
            var result4 = 10m / 3m; // Decimal division, result is decimal

            Console.WriteLine($"10 / 3 type: {result1.GetType()} - value: {result1}");
            Console.WriteLine($"10.0 / 3 type: {result2.GetType()} - value: {result2}");
            Console.WriteLine($"10 / 3.0 type: {result3.GetType()} - value: {result3}");
            Console.WriteLine($"10m / 3m type: {result4.GetType()} - value: {result4}");
        }

        ShowArithmeticInference();
    }
}
