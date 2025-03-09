# C# Arithmetic Operators Demo

This C# console application demonstrates the use of arithmetic operators, increment/decrement operators, and specialized operations on integral types.

## Features

* **Arithmetic Operators:** Shows examples of addition, subtraction, multiplication, division, and modulus operations.
* **Increment/Decrement Operators:** Illustrates the difference between pre-increment/decrement and post-increment/decrement.
* **Specialized Operations on Integral Types:**
    * Demonstrates integer division and bitwise operators (AND, OR, XOR, NOT, left shift, right shift).
    * Explains and demonstrates the `checked` and `unchecked` keywords for handling arithmetic overflow.

## Getting Started

### Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/download) installed.

### Running the Application

1.  **Clone the repository:**

    ```bash
    git clone <repository_url>
    cd <repository_directory>
    ```

2.  **Run the application:**

    ```bash
    dotnet run
    ```

    The output will display the results of the various arithmetic and bitwise operations.

## Code Explanation

### Arithmetic Operators

The code demonstrates basic arithmetic operations:

```csharp
int a = 10;
int b = 5;

Console.WriteLine($"a + b = {a + b}");
// ... other arithmetic operations

Increment and Decrement Operators
The code shows the difference between pre- and post-increment/decrement:
int x = 5;
Console.WriteLine(<span class="math-inline">"x\+\+ \(Post\-increment\)\: \{x\+\+\}"\);
Console\.WriteLine\(</span>"++x (Pre-increment): {++x}");
// ... similar decrement examples

Specialized Operations on Integral Types
Integer Division:
int num1 = 10;
int num2 = 3;
Console.WriteLine($"Integer Division (num1 / num2): {num1 / num2}");

Bitwise Operators:
int bitwiseA = 5;
int bitwiseB = 3;
Console.WriteLine($"bitwiseA & bitwiseB (AND): {bitwiseA & bitwiseB}");
// ... other bitwise operations

Checked and Unchecked:
byte byteMax = byte.MaxValue;
try
{
    checked
    {
        byte checkedResult = (byte)(byteMax + 1);
    }
}
catch (OverflowException ex)
{
    Console.WriteLine($"Checked byteMax + 1: Overflow Exception: {ex.Message}");
}

byte uncheckedResult = (byte)(byteMax + 1);
Console.WriteLine($"Unchecked byteMax + 1: {uncheckedResult}");

try{
    checked{
        const byte constOver = (byte)256;
    }
}catch(OverflowException ex){
    Console.WriteLine($"Const Over Exception: {ex.Message}");
}

Example output
--- Arithmetic Operators ---
a = 10, b = 5
a + b = 15
a - b = 5
a * b = 50
a / b = 2
a % b = 0
c = 7, d = 2
c / d = 3.5

--- Increment and Decrement Operators ---
Initial x = 5
x++ (Post-increment): 5
x (after post-increment) = 6
++x (Pre-increment): 7
x (after pre-increment) = 7
Initial y = 8
y-- (Post-decrement): 8
y (after post-decrement) = 7
--y (Pre-decrement): 6
y (after pre-decrement) = 6

--- Specialized Operations on Integral Types ---
num1 = 10, num2 = 3
Integer Division (num1 / num2): 3
bitwiseA = 5, bitwiseB = 3
bitwiseA & bitwiseB (AND): 1
bitwiseA | bitwiseB (OR): 7
bitwiseA ^ bitwiseB (XOR): 6
~bitwiseA (NOT): -6
bitwiseA << 1 (Left shift): 10
bitwiseA >> 1 (Right shift): 2

--- Checked and Unchecked Operations ---
byteMax = 255
Unchecked byteMax + 1: 0
Checked byteMax + 1: Overflow Exception: Arithmetic operation resulted in an overflow.
Const Over Exception: The operation overflows at compile time in checked mode.