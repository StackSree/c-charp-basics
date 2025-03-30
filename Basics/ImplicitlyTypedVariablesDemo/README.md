# Understanding `var` in C#

## Overview

This project demonstrates the usage of the `var` keyword in C#. The `var` keyword allows implicit typing, where the compiler infers the type of a variable from its initialization expression.

## Features

- Demonstrates how `var` infers types from different initialization expressions.
- Explores scenarios where using `var` can lead to readability issues.
- Highlights compiler behavior and type inference rules.

## Code Explanation

The program covers the following key concepts:

### 1. Basic Type Inference

```csharp
var message = "hello"; // Compiler infers string
var builder = new StringBuilder(); // Compiler infers System.Text.StringBuilder
var pi = (float)Math.PI; // Compiler infers float
```

- The compiler determines the type of each variable based on the assigned value.

### 2. Type Inspection and Output

```csharp
Console.WriteLine($"message is of type: {message.GetType()}, value: {message}");
Console.WriteLine($"builder is of type: {builder.GetType()}, value: {builder}");
Console.WriteLine($"pi is of type: {pi.GetType()}, value: {pi}");
```

- The program prints the inferred types and values of variables.

### 3. Type Safety

```csharp
var number = 5; // Compiler infers int
// number = "hello"; // This would cause a compile-time error
```

- `var` variables are strongly typed and cannot change types after initialization.

### 4. Readability Concerns

```csharp
Random r = new Random();
var randomNumber = r.Next();
Console.WriteLine($"randomNumber is of type: {randomNumber.GetType()}, value: {randomNumber}");
```

- In simple cases, `var` improves readability.
- However, in complex expressions, the type inference may not be immediately clear, potentially affecting code maintainability.

## Usage

### Steps to Run the Program

1. Compile and run the C# program using the .NET SDK.
2. Observe how the `var` keyword infers types from expressions.
3. Review the output to understand the inferred types.

### Expected Output

```sh
message is of type: System.String, value: hello
builder is of type: System.Text.StringBuilder, value:
pi is of type: System.Single, value: 3.1415927

Attempting to assign a different type to a var variable:
number is of type: System.Int32, value: 5

Demonstrating potential readability issue with var:
randomNumber is of type: System.Int32, value: 12345
```

(Note: The random number value will vary each execution.)

## Best Practices

- Use `var` for brevity when the type is obvious.
- Avoid `var` when the inferred type is unclear to improve code readability.
- Always initialize `var` variables immediately since their type must be inferred at declaration.

## Requirements

- .NET SDK installed
- C# 3.0 or later (introduced `var` keyword)

## License

This project is open-source and available under the MIT License.
