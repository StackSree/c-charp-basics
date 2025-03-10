namespace FloatingPointDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Positive Infinity
        double positiveInfinity = 1.0 / 0.0;
        Console.WriteLine($"Positive Infinity: {positiveInfinity}");
        Console.WriteLine($"Is Positive Infinity: {double.IsPositiveInfinity(positiveInfinity)}");

        // Negative Infinity
        double negativeInfinity = -1.0 / 0.0;
        Console.WriteLine($"Negative Infinity: {negativeInfinity}");
        Console.WriteLine($"Is Negative Infinity: {double.IsNegativeInfinity(negativeInfinity)}");

        // NaN (Not-a-Number)
        double nan = 0.0 / 0.0;
        Console.WriteLine($"NaN: {nan}");
        Console.WriteLine($"Is NaN: {double.IsNaN(nan)}");

        // Example with floats
        float floatPositiveInfinity = 1.0f / 0.0f;
        Console.WriteLine($"Float Positive Infinity: {floatPositiveInfinity}");
        Console.WriteLine($"Float Is Positive Infinity: {float.IsPositiveInfinity(floatPositiveInfinity)}");

        float floatNaN = 0.0f / 0.0f;
        Console.WriteLine($"Float NaN: {floatNaN}");
        Console.WriteLine($"Float Is NaN: {float.IsNaN(floatNaN)}");

        // Example of calculations resulting in these special values.
        double squareRootOfNegative = Math.Sqrt(-1.0);
        Console.WriteLine($"Square root of -1.0: {squareRootOfNegative}");
        Console.WriteLine($"Is square root of -1.0 NaN? {double.IsNaN(squareRootOfNegative)}");

        double largeNumber = double.MaxValue;
        double overflow = largeNumber * 2;
        Console.WriteLine($"Overflow: {overflow}");
        Console.WriteLine($"Is Overflow Infinity? {double.IsInfinity(overflow)}");

        //Comparing floating point numbers.
        double a = 0.1 + 0.1 + 0.1;
        double b = 0.3;

        Console.WriteLine($"a: {a}, b: {b}");
        Console.WriteLine($"a == b: {a == b}"); // Often false due to floating point precision.

        //Instead of direct equality, compare the difference.
        double tolerance = 1e-9; //A small tolerance.
        Console.WriteLine($"Math.Abs(a - b) < tolerance: {Math.Abs(a - b) < tolerance}");

    }
}