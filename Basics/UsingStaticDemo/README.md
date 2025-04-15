# Demonstrating 'using static' in C#

This project demonstrates the use of the `using static` directive in C#.

## What is 'using static'?

The `using static` directive, introduced in C# 6, allows you to import the static members (fields, properties, methods, and nested types) of a specific type directly into your current scope. This means you can use these static members without needing to qualify them with the type name.

For example, instead of writing `System.Console.WriteLine("Hello");`, you can import the `System.Console` class using `using static System.Console;` and then simply write `WriteLine("Hello");`.

## Demonstration in `Program.cs`

The `Program.cs` file showcases the following:

1.  **Importing `System.Console`:** Demonstrates calling `WriteLine` and `ReadKey` directly.
2.  **Importing `System.Math`:** Shows using `PI` and `Pow` without the `Math.` prefix.
3.  **Using static members from a custom class (`Example`):** Illustrates importing and using a static field (`Greeting`) and a static method (`PrintGreeting`).
4.  **Using static members from a custom helper class (`MyMathHelper`):** Shows importing and using a static method (`Add`).
5.  **Ambiguity Example (commented out):** Provides an example of how the compiler will generate an error if there's an ambiguity between static members with the same name imported from different types. To see this in action, uncomment the `AmbiguousNamespace1` and `AmbiguousNamespace2` sections and the `WriteLine(Multiply(2, 3));` line.
6.  **Enums and `using static`:** Explains that while the prompt's example about `Visibility` in XAML is a specific case, generally, you still qualify enum members with the enum type (e.g., `Status.Pending`). You can use `using static` on an enum type if the enum itself contains static members (though this is less common).

## How to Run

1.  Save the `Program.cs` and `README.md` files in the same directory (e.g., under a folder named `UsingStaticDemo`).
2.  Open a command prompt or terminal and navigate to the directory containing the files.
3.  Run the C# compiler (if you have the .NET SDK installed):
    ```bash
    dotnet run
    ```
    Alternatively, you can open the directory in Visual Studio or Visual Studio Code and run the project from there.

## Benefits of `using static`

- **Improved Readability:** Can make code less verbose and easier to understand when frequently using static members of a type.
- **Conciseness:** Reduces the amount of typing required.

## Potential Drawbacks

- **Ambiguity:** Can lead to compile-time errors if static members with the same name are imported from multiple types.
- **Reduced Clarity (potentially):** Overuse might make it less obvious where a static member originates from.

Use `using static` judiciously to enhance code clarity without introducing ambiguity.
