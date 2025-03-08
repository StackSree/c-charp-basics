# Floating-Point and Integral Type Conversions in C#

This C# project demonstrates various conversions between floating-point types (`float`, `double`, `decimal`) and integral types (`int`, `long`). It highlights the potential for data loss and the importance of choosing the correct data types for your calculations.

## Overview

The `FloatingPointConversions.cs` file contains a `Main` method that showcases the following:

* **Converting between floating-point types:**
    * Implicit conversion from `float` to `double`.
    * Explicit conversion from `double` to `float` (potential loss of precision).
* **Converting between floating-point and integral types:**
    * Explicit conversion from `float` to `int` (truncation).
    * Implicit conversion from `int` to `float`.
    * Explicit conversion from `long` to `float` (potential loss of precision).
* **Decimal conversions:**
    * Explicit conversion from `decimal` to `double`.
    * Explicit conversion from `double` to `decimal`.
    * Explicit conversion from `decimal` to `int`.
    * Implicit conversion from `int` to `decimal`.
* **Demonstration of precision loss with `float`.**

## Getting Started

1.  **Prerequisites:**
    * .NET SDK installed.
2.  **Clone the repository:**
    ```bash
    git clone [repository URL]
    cd [repository directory]
    ```
3.  **Run the application:**
    ```bash
    dotnet run
    ```

## Code Examples

Here are some key code snippets from the `FloatingPointConversions.cs` file:

```csharp
// Converting double to float (explicit, potential loss of precision)
double anotherDouble = 1.234567890123456789;
float anotherFloat = (float)anotherDouble;

// Converting float to int (explicit, truncation)
float floatToInt = 3.99f;
int intValue = (int)floatToInt;

//Converting long to float (explicit, potential loss of precision)
long longToFloat = 9007199254740993;
float floatFromLong = longToFloat;

//Converting Decimal to double.
decimal decimalValue = 12345.6789m;
double doubleFromDecimal = (double)decimalValue;

//Demonstrating loss of precision with floats
float largeFloat = 16777216f;
Console.WriteLine(<span class="math-inline">"Large float\: \{largeFloat\}"\);
Console\.WriteLine\(</span>"Large float + 1: {largeFloat + 1}");

## Key Takeaways
Implicit conversions occur when there's no risk of data loss.
Explicit conversions (casts) are necessary when there's a potential for data loss.
The decimal type is designed for financial calculations where precision is crucial.
float has limited precision, which can lead to rounding errors with large numbers.
Be mindful of potential overflows when converting floating point numbers to integer types.