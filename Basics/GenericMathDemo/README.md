# Generic Mathematical Functions in C#

This C# program demonstrates the use of generic mathematical functions using `INumber<T>` and `IRootFunctions<T>` interfaces. It includes:
- A generic sum function
- Root Mean Square (RMS) calculation
- Financial interest calculation

## Features
- **Generic Sum Function**: Computes the sum of an array of numbers (supports `int`, `double`, `decimal`, etc.).
- **RMS Calculation**: Computes the root mean square of a set of values.
- **Financial Interest Calculation**: Applies compound interest to a given principal amount over a period of years.

## Code Overview
### Main Function
```csharp
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
```

### Generic Sum Function
```csharp
static T Sum<T>(params T[] numbers) where T : INumber<T>
{
    T total = T.Zero;
    foreach (T n in numbers)
        total += n;
    return total;
}
```

### Root Mean Square (RMS) Calculation
```csharp
static T RMS<T>(params T[] values) where T : INumber<T>, IRootFunctions<T>
{
    T total = T.Zero;
    foreach (T value in values)
        total += value * value;

    T count = T.CreateChecked(values.Length);
    return T.RootN(total / count, 2);
}
```

### Financial Interest Calculation
```csharp
static T ApplyInterest<T>(T principal, T rate, int years) where T : INumber<T>
{
    T hundred = T.CreateChecked(100);
    T rateFraction = rate / hundred;
    T total = principal;

    for (int i = 0; i < years; i++)
        total += total * rateFraction;

    return total;
}
```

## Prerequisites
- .NET 7 or later (for `INumber<T>` and `IRootFunctions<T>` support)
- C# 11 or later

## Expected Output
```
Sum of Integers: 15
Sum of Doubles: 15.6
Sum of Decimals: 15.6
RMS of [3, 4, 5]: 4.08248
Future Value after 3 years: 1157.63
```

## License
This project is open-source and available under the MIT License.

