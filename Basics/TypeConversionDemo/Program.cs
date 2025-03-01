namespace TypeConversionDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Implicit Conversion
        int intValue = 100;
        long longValue = intValue; // Implicit conversion from int to long
        float floatValue = 12.5f;
        double doubleValue = floatValue; // Implicit conversion from float to double

        Console.WriteLine("Implicit Conversion:");
        Console.WriteLine($"int: {intValue}, long: {longValue}");
        Console.WriteLine($"float: {floatValue}, double: {doubleValue}");

        // Explicit Conversion
        double doubleValue2 = 123.789;
        int intValue2 = (int)doubleValue2; // Explicit conversion from double to int (truncation)
        float floatValue2 = 45.67f;
        int intValue3 = (int)floatValue2; // Explicit conversion from float to int (truncation)
        long longValue2 = 9876543210;
        int intValue4 = (int)longValue2; // Explicit conversion from long to int (potential overflow)

        Console.WriteLine("\nExplicit Conversion:");
        Console.WriteLine($"double: {doubleValue2}, int: {intValue2}");
        Console.WriteLine($"float: {floatValue2}, int: {intValue3}");
        Console.WriteLine($"long: {longValue2}, int: {intValue4}");

        // Using Convert class
        string stringValue = "42";
        int convertedIntValue = Convert.ToInt32(stringValue); // Explicit conversion string to int using Convert
        Console.WriteLine($"\nString: {stringValue}, convertedInt: {convertedIntValue}");

        // Using Parse method
        string stringFloat = "3.14159";
        float parsedFloat = float.Parse(stringFloat);
        Console.WriteLine($"\nString: {stringFloat}, parsedFloat: {parsedFloat}");

        //Using TryParse
        string stringTryInt = "abc";
        int tryIntResult;
        bool success = int.TryParse(stringTryInt, out tryIntResult);

        if (success)
        {
            Console.WriteLine($"\nString: {stringTryInt}, TryParse Result: {tryIntResult}");
        }
        else
        {
            Console.WriteLine($"\nString: {stringTryInt}, TryParse failed.");
        }
    }
}
