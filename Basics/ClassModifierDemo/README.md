# C# Class Modifier Demonstrations

This console application demonstrates the use of various non-nested class modifiers in C#. Each class showcases the behavior and implications of using keywords like `public`, `internal`, `abstract`, `sealed`, `static`, and `partial`.

## Overview

The application includes the following classes, each illustrating a different class modifier:

- **`PublicClassDemo`**: Demonstrates a class with `public` accessibility, meaning it can be accessed from anywhere.
- **`InternalClassDemo`**: Shows a class with `internal` accessibility, limiting its use to within the same assembly.
- **`Shape` (abstract) and `Circle`**: Illustrates an `abstract` base class (`Shape`) that cannot be instantiated and a derived class (`Circle`) that inherits from it and provides a concrete implementation for an abstract method.
- **`FinalUtility` (sealed)**: Presents a `sealed` class, which cannot be inherited from.
- **`StringHelper` (static)**: Demonstrates a `static` class containing utility methods that can be accessed directly without creating an instance of the class.
- **`UserProfile` (partial)**: Shows how a class definition can be split across multiple parts using the `partial` keyword (in this example, both parts are in the same file for simplicity).

## Getting Started

1.  **Save the Code:** Save the provided C# code as a `.cs` file (e.g., `Program.cs`).
2.  **Compile:** Open a command prompt or terminal, navigate to the directory where you saved the file, and compile the code using the C# compiler:
    ```bash
    csc Program.cs
    ```
3.  **Run:** After successful compilation, an executable file (`Program.exe`) will be created. Run it from the command prompt or terminal:
    ```bash
    Program.exe
    ```

## Output

The console output will demonstrate the functionality of each class:
PublicClassDemo: This is a public class.

InternalClassDemo: This is an internal secret.

Shape Area: 78.53981633974483

FinalUtility Current Date: 20-4-2025

Original: hello, Reversed: olleh

UserProfile Full Name: John Doe
UserProfile: Welcome, John Doe ([email address removed])!

## Class Modifier Summary

- **`public`**: Accessible from any code.
- **`internal`**: Accessible only within the same assembly.
- **`abstract`**: Cannot be instantiated; serves as a base class for inheritance and can contain abstract members.
- **`sealed`**: Cannot be inherited from.
- **`static`**: Cannot be instantiated and contains only static members; accessed directly through the class name.
- **`partial`**: Allows the definition of a class to be split across multiple source files.

## Real-World Use Cases (Recap)

- **`public`**: Utility classes, data transfer objects (DTOs) for cross-assembly access.
- **`internal`**: Helper classes, implementation details within a specific module.
- **`abstract`**: Defining blueprints for related classes (e.g., different types of shapes, payment processors).
- **`sealed`**: Utility classes with static methods, preventing unintended modification of core logic.
- **`static`**: Global utility functions, constants.
- **`partial`**: Separating auto-generated code from manual code, improving organization for large classes.

This simple application provides a practical understanding of how C# class modifiers control the accessibility and behavior of your classes.
