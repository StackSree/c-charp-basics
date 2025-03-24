# Definite Assignment in C#

## Overview
C# enforces a **definite assignment** policy, ensuring that variables are properly initialized before use. This prevents accidental access to uninitialized memory, enhancing code safety and reliability.

### Key Rules of Definite Assignment
1. **Local variables** must be explicitly assigned a value before being read.
2. **Function arguments** must be supplied when calling a method (unless marked as optional).
3. **Fields and array elements** are automatically initialized to their default values.

## Code Example
The following C# program demonstrates definite assignment:

```csharp
using System;

class Test
{
    // Static field: automatically initialized to 0.
    public static int X;

    // Instance field: automatically initialized to 0.
    public int InstanceField;

    public static void Main()
    {
        // 1. Local variable: must be assigned before use.
        // Uncommenting the following lines would cause a compile-time error:
        // int localVar;
        // Console.WriteLine("Local variable: " + localVar); // Error: unassigned variable

        int localVar = 5; // Correctly initialized
        Console.WriteLine("Local variable value: " + localVar);  // Outputs: 5

        // 2. Array elements: automatically initialized to default values.
        int[] ints = new int[3];
        Console.WriteLine("First element in the array: " + ints[0]); // Outputs: 0

        // 3. Fields: automatically initialized to default values.
        Console.WriteLine("Static field X: " + Test.X); // Outputs: 0

        // Instance field is also initialized to 0.
        Test t = new Test();
        Console.WriteLine("Instance field value: " + t.InstanceField); // Outputs: 0
    }
}
```

## Explanation
- **Local Variables**: Must be explicitly assigned before use; otherwise, a compile-time error occurs.
- **Array Elements**: Automatically initialized to their default values (e.g., `0` for integers).
- **Fields**: Both static and instance fields are initialized to their default values.

## Running the Code
1. Copy the above code into a file named `Program.cs`.
2. Compile and run it using the .NET CLI:
   ```sh
   dotnet run
   ```
3. Observe the output demonstrating definite assignment rules.

## Expected Output
```
Local variable value: 5
First element in the array: 0
Static field X: 0
Instance field value: 0
```

## Conclusion
C#'s definite assignment policy ensures safer and more predictable code execution by preventing uninitialized variable usage. This helps avoid runtime errors and unexpected behavior in applications.

