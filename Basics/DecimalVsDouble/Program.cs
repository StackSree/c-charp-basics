namespace DecimalVsDouble;

internal class Program
{
    static void Main(string[] args)
    {

        // Example with double (potential rounding errors)
        double doubleSum = 0.0;
        for (int i = 0; i < 10; i++)
        {
            doubleSum += 0.1;
        }
        Console.WriteLine($"Double sum: {doubleSum}"); // Output may not be exactly 1.0

        // Example with decimal (exact representation)
        decimal decimalSum = 0.0m; // 'm' suffix indicates decimal literal
        for (int i = 0; i < 10; i++)
        {
            decimalSum += 0.1m;
        }
        Console.WriteLine($"Decimal sum: {decimalSum}"); // Output will be exactly 1.0

        //Example of a small rounding error in double.
        double a = 0.1 + 0.2;
        Console.WriteLine($"double 0.1 + 0.2: {a}");

        decimal b = 0.1m + 0.2m;
        Console.WriteLine($"decimal 0.1 + 0.2: {b}");

        //Example of a very large number difference.
        double doubleLarge = 1.0 / 3.0;
        decimal decimalLarge = 1.0m / 3.0m;

        Console.WriteLine($"Double 1/3: {doubleLarge}");
        Console.WriteLine($"Decimal 1/3: {decimalLarge}");
        Console.WriteLine($"Double 1/3 with 30 digits: {doubleLarge.ToString("G30")}");
        Console.WriteLine($"Decimal 1/3 with 30 digits: {decimalLarge.ToString("G30")}");
    }
}

