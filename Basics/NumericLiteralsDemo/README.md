# Numeric Literals and Type Inference Demo in C#

This C# program demonstrates various numeric literals and the type inference capabilities of the `var` keyword.

## Numeric Literals

The program covers:

-   **Integer Literals:**
    -      Decimal (base 10)
    -      Hexadecimal (base 16)
    -      Binary (base 2)
    -      Long literals (with `L` suffix)
    -      Unsigned integer literals (with `U` and `UL` suffixes)
-   **Floating-Point Literals:**
    -      Double literals (default)
    -      Float literals (with `f` suffix)
    -      Decimal literals (with `m` suffix)
    -   Scientific notation.
-   **Digit Separators:**
    -   Using underscores `_` to improve readability of large numeric literals.

## Type Inference

The program demonstrates how the `var` keyword infers the type of numeric literals:

-      `var inferredInt = 100;` (inferred as `int`)
-   `var inferredDouble = 100.5;` (inferred as `double`)
-   `var inferredDecimal = 100.5m;` (inferred as `decimal`)

It also shows how arithmetic operations affect type inference, for example integer division vs double division.

## How to Run

1.  **Save the code:** Save the C# code as `NumericLiteralsDemo.cs`.
2.  **Compile:** Open a terminal or command prompt and navigate to the directory where you saved the file. Then, compile the code using the C# compiler:
    ```bash
    csc NumericLiteralsDemo.cs
    ```
3.  **Run:** Execute the compiled program:
    ```bash
    NumericLiteralsDemo.exe
    ```

## Output

The program will output the values and types of the various numeric literals and inferred variables to the console, demonstrating how C# handles numeric types and inference.