# Operator Precedence and Associativity in C#

## Overview

This project demonstrates the concepts of **operator precedence** and **associativity** in C#. The code showcases how different operators are evaluated based on their precedence and associativity rules.

## Code Explanation

The program prints examples of various operators and how their evaluation order affects the final result.

### Examples Covered:

1. **Multiplication (\*) has higher precedence than Addition (+)**

   ```csharp
   int result1 = 10 + 5 * 2; // Evaluates as 10 + (5 * 2) = 10 + 10 = 20
   ```

   **Output:** `10 + 5 * 2 = 20`

2. **Using Parentheses to Change Precedence**

   ```csharp
   int result2 = (10 + 5) * 2; // Evaluates as (10 + 5) * 2 = 15 * 2 = 30
   ```

   **Output:** `(10 + 5) * 2 = 30`

3. **Left-to-Right Associativity of Arithmetic Operators**

   ```csharp
   int result3 = 100 / 10 * 5; // Evaluates as (100 / 10) * 5 = 10 * 5 = 50
   ```

   **Output:** `100 / 10 * 5 = 50`

4. **Right-to-Left Associativity of Assignment Operator**

   ```csharp
   int a, b;
   a = b = 20; // First b = 20, then a = b
   ```

   **Output:** `a = b = 20 -> a: 20, b: 20`

5. **Logical AND (&&) has higher precedence than Logical OR (||)**

   ```csharp
   bool boolResult = true || false && false; // false && false = false, then true || false = true
   ```

   **Output:** `true || false && false = true`

6. **Conditional (Ternary) Operator Precedence**
   ```csharp
   int x = 5, y = 10;
   int min = (x < y) ? x : y; // ?: has lower precedence than comparison <
   ```
   **Output:** `(5 < 10) ? 5 : 10 = 5`

## How to Run

1. Copy the code into a C# console application.
2. Compile and execute the program.
3. Observe the output in the console, demonstrating how operator precedence and associativity affect expressions.

## Conclusion

Understanding operator precedence and associativity is crucial for writing clear and predictable code. This demo provides a hands-on way to grasp these concepts in C#.
