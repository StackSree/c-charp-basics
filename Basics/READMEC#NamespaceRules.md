# C# Namespace Rules and Demo

This document explains the rules and conventions for using namespaces in C# and provides a practical demonstration.

## Namespaces in C#

Namespaces are used to organize code and prevent naming collisions by creating containers for types (classes, interfaces, structs, enums, and delegates).

## Rules and Conventions

1.  **Uniqueness of Names:**

    - Within the same namespace, all type names must be unique.

2.  **Nested Namespaces:**

    - Namespaces can be nested to create a hierarchical structure.

3.  **`using` Directive:**

    - The `using` directive allows you to import namespaces, enabling the use of types without their fully qualified names.
    - You can also create aliases for namespaces or types using the `using` directive.

4.  **Accessibility Modifiers:**

    - Types within a namespace can have `public` or `internal` accessibility:
      - `public`: Accessible from any code.
      - `internal`: Accessible only within the same assembly.

5.  **Partial Types:**

    - Parts of a partial type declaration must reside within the same namespace.

6.  **Global Namespace:**
    - Types not explicitly declared within a namespace are part of the global namespace.

## Demo

The following code demonstrates these rules:

```csharp
// File: MathOperations.cs
namespace MyCompany.Math
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        internal int Multiply(int a, int b) => a * b;
    }
}

// File: StringUtilities.cs
namespace MyCompany.Utilities
{
    public static class StringHelper
    {
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}

// File: Program.cs
using System;
using MyCompany.Math;
using Utility = MyCompany.Utilities.StringHelper;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine($"Sum: {calculator.Add(5, 3)}");

            // The following line would cause a compilation error because Multiply is internal:
            // Console.WriteLine($"Product: {calculator.Multiply(5, 3)}");

            string reversed = Utility.Reverse("hello");
            Console.WriteLine($"Reversed: {reversed}");

            DateTime now = DateTime.Now;
            Console.WriteLine($"Current time: {now}");
        }
    }
}
ExplanationNamespaces: The code defines two namespaces: MyCompany.Math and MyCompany.Utilities.Classes: The MyCompany.Math namespace contains the Calculator class, and the MyCompany.Utilities namespace contains the StringHelper class.using Directive: The Program.cs file uses the using directive to access the MyCompany.Math namespace and a using alias to access MyCompany.Utilities.StringHelper.Accessibility: The Add method in the Calculator class is public, while the Multiply method is internal. This demonstrates how internal access restricts access to within the same assembly.Global Namespace: The System namespace is used without explicit qualification due to the using System; directive. DateTime is part of the System namespace.
```
