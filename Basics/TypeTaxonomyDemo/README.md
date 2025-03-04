# C# Predefined Type Taxonomy Demo

This project demonstrates the predefined type taxonomy in C#, illustrating the key categories and relationships between built-in data types.

## Overview

A predefined type taxonomy in C# refers to the hierarchical organization and classification of the built-in data types provided by the language and the .NET framework. These types form the foundation of C# programming and are essential for defining and manipulating data.

This project provides a practical example of:

1.  **Value Types:**
    * Simple Types (Integral, Floating-Point, Boolean)
    * Enumeration Types (Enums)
    * Structure Types (Structs)
2.  **Reference Types:**
    * Class Types
    * Interface Types
    * Delegate Types
    * Array Types
    * String Type
    * Object Type
3.  **Pointer Types:**
    * Demonstrates the need for unsafe code.

## Key Concepts

* **Value Types:** Store data directly in memory.
* **Reference Types:** Store references (memory addresses) to data.
* **Pointer Types:** Store memory addresses directly, requiring `unsafe` code.
* All types ultimately derive from `System.Object`.
* `System.ValueType` is the base class for all value types.

## Project Structure

* `TypeTaxonomyDemo.cs`: Contains the C# code demonstrating the type taxonomy.

## Getting Started

1.  **Clone the repository:**

    ```bash
    git clone [repository URL]
    ```

2.  **Compile the code:**

    * **Using Visual Studio:** Open the project and build it.
    * **Using the command-line compiler (csc):**

        ```bash
        csc /unsafe TypeTaxonomyDemo.cs
        ```

        **Note:** The `/unsafe` flag is required because the demo includes pointer type examples.

3.  **Run the executable:**

    ```bash
    TypeTaxonomyDemo.exe
    ```

## Example Code Snippet

```csharp
int myInt = 10; // Value type (simple type)
string myString = "Hello"; // Reference type (string)
bool myBool = true; // Value type (simple type)
object myObject = myString; // Reference type (object)
int[] myArray = new int[5]; // Reference type (array)
public enum Days { Monday, Tuesday, Wednesday} // value type (enum)


Right-click your project in the Solution Explorer.
Select Properties.
Go to the Build tab.
Check the box labeled Allow unsafe code.
Save your changes.



unsafe{
    int num = 42;
    int* ptr = &num;
    Console.WriteLine($"Unsafe pointer: {*ptr}");
}