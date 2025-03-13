# C# Boolean Type and Operators

This repository provides a demonstration of the `bool` type and its associated operators in C#. The `bool` type is fundamental in C# for representing logical values, holding either `true` or `false`.

## Overview

The `bool` type is used extensively in conditional statements, logical expressions, and as the result of comparison operations. This repository covers the following aspects:

1.  **The `bool` Type:**
    * Definition: An alias for the `.NET System.Boolean` structure.
    * Usage: In conditional statements (`if`, `while`) and logical expressions.
2.  **Boolean Operators:**
    * Logical Negation (`!`): Inverts the value of a Boolean operand.
    * Logical AND (`&`): Returns `true` if both operands are `true`. Always evaluates both operands.
    * Logical OR (`|`): Returns `true` if either operand is `true`. Always evaluates both operands.
    * Logical Exclusive OR (`^`): Returns `true` if operands are different.
    * Conditional Logical AND (`&&`): Short-circuiting AND.
    * Conditional Logical OR (`||`): Short-circuiting OR.
    * Equality (`==`) and Inequality (`!=`): Compares values and returns a `bool`.
3.  **Key Considerations:**
    * Short-circuiting (`&&`, `||`): Performance and error prevention.
    * Operator Precedence: Use parentheses for clarity.
    * Nullable Booleans (`bool?`): Handling unknown Boolean values.

## Demo Code

The `BooleanDemo.cs` file contains a C# program demonstrating the usage of these operators. It includes examples of:

* Logical negation (`!`).
* Logical AND (`&`).
* Logical OR (`|`).
* Logical Exclusive OR (`^`).
* Conditional Logical AND (`&&`) with short-circuiting.
* Conditional Logical OR (`||`) with short-circuiting.
* Equality (`==`) and inequality (`!=`).
* Nullable Boolean (`bool?`) usage.

## How to Run

1.  **Clone the repository:**

    ```bash
    git clone [repository URL]
    cd [repository directory]
    ```

2.  **Compile and run the C# code:**

    ```bash
    dotnet run
    ```

    (Ensure you have the .NET SDK installed.)

## Example Output

The program will output the results of each Boolean operation to the console, demonstrating the behavior of the operators.
!true: false
!false: true
true & true: true
true & false: false
false & false: false
true | true: true
true | false: true
false | false: false 1 
true ^ true: false
true ^ false: true
false ^ false: false
true 2  && true: true
true && false: false
x after short-circuit &&: 5
true || false: true
false || true: true
x after short-circuit ||: 5
true == true: true
true != false: true
Nullable boolean is null: True
Nullable boolean is true: True
Nullable boolean is false: True


# Conditional (Ternary) Operator
The conditional operator provides a concise way to write `if-else` statements. It's the only operator in C# that takes three operands, hence the name "ternary operator."

## Syntax

The syntax of the ternary operator is:

```csharp
condition ? expressionIfTrue : expressionIfFalse;


## Contributing

Feel free to contribute to this repository by submitting pull requests or opening issues.

## License

This project is licensed under the MIT License.