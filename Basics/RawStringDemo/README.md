# C# 11 Raw String Literal Demo

This repository contains a simple C# console application that demonstrates the features of raw string literals introduced in C# 11.

## Features Demonstrated

* **Single-line raw string literals:** Showing how to avoid escaping special characters like `\` and `"`.
* **Embedding triple quotes:** Demonstrating how to include the `"""` sequence within a raw string literal.
* **Multiline raw string literals:** Illustrating the handling of indentation and whitespace.
* **Interpolated raw string literals:** Showing how to use string interpolation with raw string literals.
* **Escaping curly braces in interpolated raw string literals:** Shows the use of multiple dollar signs, and how to escape curly braces.
* **Indentation rules:** Demonstrating the importance of consistent indentation in multiline raw string literals and showing an example of a compile time error.

## Prerequisites

* [.NET 6 or later SDK](https://dotnet.microsoft.com/download)

## How to Run

1.  **Clone the repository:**

    ```bash
    git clone <repository_url>
    cd raw-string-literal-demo
    ```

2.  **Run the application:**

    ```bash
    dotnet run
    ```

    This will execute the C# program and display the output in the console.

## Code Explanation

The `RawStringDemo.cs` file contains the C# code that showcases the different aspects of raw string literals. Key examples include:

* Using `"""` to create raw strings for XML and JSON.
* Handling embedded `"""` sequences with `""""`.
* Demonstrating the indentation rules for multiline raw strings.
* Using `$"""` for string interpolation.
* Using `$$"""` to escape curly braces in interpolated raw strings.

## Example Output
Single-line XML:
<element attribute="value">Content</element>

Embedded triple quotes:
"This string contains """ triple quotes."

Multiline JSON:
{
"name": "Alice",
"age": 30,
"city": "New York"
}

Multiline code:
public class Example
{
public void Method()
{
Console.WriteLine("Hello, world!");
}
}

Interpolated raw string:
My name is Bob and I am 25 years old.

Escaped curly braces in interpolated raw string:
The number is 5. To escape a curly brace use { }. To display the variable within curly braces use { 5 }

Correctly indented multiline raw string:
Line 1
Line 2

## Contributing

Feel free to contribute to this project by submitting pull requests or opening issues.

## License

This project is licensed under the [MIT License](LICENSE).