namespace FloatingPointConversions;

internal class Program
{
    static void Main(string[] args)
    {
        // Converting between floating-point types
        float floatValue = 3.14159f;
        double doubleValue = floatValue; // Implicit conversion (float to double)
        Console.WriteLine($"Float to double: {doubleValue}");

        double anotherDouble = 1.234567890123456789;
        float anotherFloat = (float)anotherDouble; // Explicit conversion (double to float)
        Console.WriteLine($"Double to float: {anotherFloat}"); // Potential loss of precision

        // Converting between floating-point and integral types
        float floatToInt = 3.99f;
        int intValue = (int)floatToInt; // Explicit conversion (float to int, truncation)
        Console.WriteLine($"Float to int: {intValue}");

        int intToFloat = 10;
        float floatFromInt = intToFloat; // Implicit conversion (int to float)
        Console.WriteLine($"Int to float: {floatFromInt}");

        long longToFloat = 9007199254740993; //A number that loses precision when converted to float.
        float floatFromLong = longToFloat;
        Console.WriteLine($"Long to float: {floatFromLong}"); //Loss of precision

        // Decimal conversions (decimal type)
        decimal decimalValue = 12345.6789m;
        double doubleFromDecimal = (double)decimalValue; // Explicit conversion (decimal to double)
        Console.WriteLine($"Decimal to double: {doubleFromDecimal}");

        decimal decimalFromDouble = (decimal)doubleValue; //Explicit conversion double to decimal.
        Console.WriteLine($"Double to decimal: {decimalFromDouble}");

        int intFromDecimal = (int)decimalValue;
        Console.WriteLine($"Decimal to int: {intFromDecimal}");

        decimal decimalFromInt = 5;
        Console.WriteLine($"Int to decimal: {decimalFromInt}");

        //Demonstrating loss of precision with floats.
        float largeFloat = 16777216f; //2^24.
        Console.WriteLine($"Large float: {largeFloat}");
        Console.WriteLine($"Large float + 1: {largeFloat + 1}"); //Notice that this is the same as the previous line.
        Console.WriteLine($"Large float + 2: {largeFloat + 2}"); //Now it changes.

    }
}
