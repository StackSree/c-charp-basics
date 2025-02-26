using System.Numerics;

namespace GenericMathDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Generic Sum Function Demo
        Console.WriteLine("Sum of Integers: " + Sum(3, 5, 7));       // int
        Console.WriteLine("Sum of Doubles: " + Sum(3.2, 5.3, 7.1));   // double
        Console.WriteLine("Sum of Decimals: " + Sum(3.2m, 5.3m, 7.1m)); // decimal

        // RMS Calculation Demo
        Console.WriteLine("RMS of [3, 4, 5]: " + RMS(3.0, 4.0, 5.0));

        // Financial Interest Calculation Demo
        decimal principal = 1000m;
        decimal rate = 5m;  // 5% interest
        int years = 3;
        Console.WriteLine($"Future Value after {years} years: {ApplyInterest(principal, rate, years)}");
    }

    // ✅ Generic Sum Function using INumber<T>
    static T Sum<T>(params T[] numbers) where T : INumber<T>
    {
        T total = T.Zero;
        foreach (T n in numbers)
            total += n;
        return total;
    }

    // ✅ Generic Root Mean Square (RMS) Calculation using IRootFunctions<T>
    static T RMS<T>(params T[] values) where T : INumber<T>, IRootFunctions<T>
    {
        T total = T.Zero;
        foreach (T value in values)
            total += value * value;

        T count = T.CreateChecked(values.Length); // Convert int to T
        return T.RootN(total / count, 2); // Compute square root
    }

    // ✅ Generic Financial Interest Calculation
    static T ApplyInterest<T>(T principal, T rate, int years) where T : INumber<T>
    {
        T hundred = T.CreateChecked(100);
        T rateFraction = rate / hundred; // Convert percentage to fraction
        T total = principal;

        for (int i = 0; i < years; i++)
            total += total * rateFraction; // Compound interest

        return total;
    }
}
