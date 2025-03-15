namespace CharConversionsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        char myChar = 'A';

        // Implicit conversions (safe, no loss of data)
        ushort ushortValue = myChar; // Implicit conversion to ushort
        int intValue = myChar;       // Implicit conversion to int
        long longValue = myChar;     // Implicit conversion to long
        float floatValue = myChar;   // Implicit conversion to float
        double doubleValue = myChar; // Implicit conversion to double
        decimal decimalValue = myChar; // Implicit conversion to decimal

        Console.WriteLine($"Implicit conversions:");
        Console.WriteLine($"  ushort: {ushortValue}");
        Console.WriteLine($"  int: {intValue}");
        Console.WriteLine($"  long: {longValue}");
        Console.WriteLine($"  float: {floatValue}");
        Console.WriteLine($"  double: {doubleValue}");
        Console.WriteLine($"  decimal: {decimalValue}");

        // Explicit conversions (may result in loss of data or exceptions)
        byte byteValue = (byte)myChar; // Explicit conversion to byte (may truncate)
        short shortValue = (short)myChar; // Explicit conversion to short

        Console.WriteLine($"\nExplicit conversions:");
        Console.WriteLine($"  byte: {byteValue}");
        Console.WriteLine($"  short: {shortValue}");

        //Example of a larger char, that would not fit into a byte.
        char largerChar = 'Ω'; //Omega symbol.
        byte largerByte;

        try
        {
            largerByte = (byte)largerChar;
            Console.WriteLine($"\nExplicit conversion of larger char to byte: {largerByte}");
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"\nExplicit conversion of larger char to byte caused an OverflowException: {e.Message}");
        }

        //Example of negative short.
        char anotherChar = (char)65535; // Maximum possible char value.
        short anotherShort = (short)anotherChar;

        Console.WriteLine($"\nExplicit conversion of char with max value to short: {anotherShort}");

        //Demonstrating that chars are treated as unsigned shorts.
        char minChar = (char)0;
        char maxChar = (char)65535;

        Console.WriteLine($"\nMinimum char value: {(ushort)minChar}");
        Console.WriteLine($"Maximum char value: {(ushort)maxChar}");

        // Demonstrating that chars are just their unicode values.
        char symbol = '∑';
        Console.WriteLine($"\nThe unicode value of {symbol} is: {(int)symbol}");
    }
}
