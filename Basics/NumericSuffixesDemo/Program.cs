namespace NumericSuffixesDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Integer Literals
        int intValue = 10;
        uint uintValue = 20U; // or 20u
        long longValue = 30L; // or 30l
        ulong ulongValue = 40UL; // or 40ul, 40Lu, 40LU, 40uL, 40Ul, etc.

        Console.WriteLine($"int: {intValue}, type: {intValue.GetType()}");
        Console.WriteLine($"uint: {uintValue}, type: {uintValue.GetType()}");
        Console.WriteLine($"long: {longValue}, type: {longValue.GetType()}");
        Console.WriteLine($"ulong: {ulongValue}, type: {ulongValue.GetType()}");

        // Floating-Point Literals
        float floatValue = 1.23f; // or 1.23F
        double doubleValue = 4.56; // No suffix needed for double (default)
        decimal decimalValue = 7.89m; // or 7.89M

        Console.WriteLine($"float: {floatValue}, type: {floatValue.GetType()}");
        Console.WriteLine($"double: {doubleValue}, type: {doubleValue.GetType()}");
        Console.WriteLine($"decimal: {decimalValue}, type: {decimalValue.GetType()}");

        // Hexadecimal and Binary Literals
        int hexValue = 0xAF10; // Hexadecimal
        int binaryValue = 0b101010; // Binary (C# 7.0 and later)

        Console.WriteLine($"hex: {hexValue}, type: {hexValue.GetType()}");
        Console.WriteLine($"binary: {binaryValue}, type: {binaryValue.GetType()}");

        //Examples of potential errors when not using suffixes.

        //Example of a number too large for int without a suffix.
        try
        {
            //int largeIntValue = 2147483648; //This will cause a compile time error, because it is too large for an int.
            long largeLongValue = 2147483648L; //This works, because of the L suffix.
            Console.WriteLine($"largeLongValue: {largeLongValue}, type: {largeLongValue.GetType()}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        //Example of double being inferred when float is intended.
        double inferredDouble = 1.1; //This is a double.
        float correctFloat = 1.1f; //This is a float.

        Console.WriteLine($"inferredDouble: {inferredDouble}, type: {inferredDouble.GetType()}");
        Console.WriteLine($"correctFloat: {correctFloat}, type: {correctFloat.GetType()}");

        //Example of potential decimal precision loss without the m suffix.

        double doubleForDecimal = 0.1 + 0.1 + 0.1;
        decimal correctDecimal = 0.1m + 0.1m + 0.1m;

        Console.WriteLine($"doubleForDecimal: {doubleForDecimal}");
        Console.WriteLine($"correctDecimal: {correctDecimal}");
    }
}
