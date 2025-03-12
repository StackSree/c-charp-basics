namespace RoundingErrorsDemo;

internal class Program
{
    static void Main(string[] args)
    {

        // Example 1: Simple Addition
        double a = 0.1;
        double b = 0.2;
        double c = a + b;
        Console.WriteLine($"0.1 + 0.2 = {c}"); // Output: 0.30000000000000004 (not exactly 0.3)

        // Example 2: Looping and Accumulation
        double sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += 0.1;
        }
        Console.WriteLine($"Sum of 10 * 0.1 = {sum}"); // Output: 0.9999999999999999 (not exactly 1.0)

        // Example 3: Financial Calculation (using decimal)
        decimal price = 1.99m;
        decimal quantity = 10m;
        decimal total = price * quantity;
        Console.WriteLine($"1.99 * 10 = {total}"); // Output: 19.9 (exact)

        // Example 4: Comparison with Tolerance
        double x = 0.3;
        double y = 0.1 + 0.2;
        double epsilon = 1e-9; // Small tolerance value

        if (Math.Abs(x - y) < epsilon)
        {
            Console.WriteLine("0.3 and 0.1 + 0.2 are approximately equal.");
        }
        else
        {
            Console.WriteLine("0.3 and 0.1 + 0.2 are not exactly equal.");
        }

        //Example 5: Demonstrating Kahan Summation
        double[] numbers = new double[] { 1.0, 1e-9, 1.0, 1e-9, 1.0 };
        double standardSum = 0;
        double kahanSum = 0;
        double cKahan = 0; //compensation variable.

        foreach (double value in numbers)
        {
            standardSum += value;
        }

        Console.WriteLine($"Standard Sum: {standardSum}");

        foreach (double value in numbers)
        {
            double yKahan = value - cKahan;
            double tKahan = kahanSum + yKahan;
            cKahan = (tKahan - kahanSum) - yKahan;
            kahanSum = tKahan;
        }

        Console.WriteLine($"Kahan Sum: {kahanSum}");

        //Example 6: Showing the problem with large numbers and small differences.
        double bigNumber = 1000000000000000;
        double smallNumber = 1;
        double result = bigNumber + smallNumber;
        Console.WriteLine($"Big Number + Small Number: {result}");
        //Notice the output is the same as bigNumber.
        //This is because the small number is insignificant in the context of the large number,
        //and is lost due to the limited precision of doubles.
    }
}

