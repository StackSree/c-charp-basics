# Value Types vs. Reference Types in C#

This demo illustrates the fundamental difference between value types and reference types in C#.

## Value Types

-   Value types store their data directly within their own memory allocation.
-   When you assign a value type variable to another variable, a copy of the value is created.
-   Modifying one variable does not affect the other.
-   Examples: `int`, `bool`, `struct`, `enum`, `decimal`.

### Illustration:
![Value Types Example](images/value_types.png)

## Reference Types

-   Reference types store a reference (memory address) to the data.
-   When you assign a reference type variable to another variable, both variables point to the same memory location.
-   Modifying one variable affects the other because they both refer to the same data.
-   Examples: `class`, `string`, `array`, `delegate`, `interface`.

### Illustration:
![Reference Types Example](images/reference_types.png)

## String Behavior

-   `string` is a reference type, but it behaves somewhat like a value type due to its immutability.
-   When you "modify" a string, a new string object is created.

### Illustration:
![String Behavior](images/string_behavior.png)

## Running the Demo

1.  Save the C# code as `ValueTypesVsReferenceTypesDemo.cs`.
2.  Compile the code using the C# compiler: `csc ValueTypesVsReferenceTypesDemo.cs`
3.  Run the compiled executable: `ValueTypesVsReferenceTypesDemo.exe`

## Output Explanation

The output of the program demonstrates how changes to value types and reference types affect other variables.

-   Value type changes do not propagate to the original variable.
-   Reference type changes do propagate to the original variable.
-   The string example shows how a new string is created when a string is edited.
-   The List example demonstrates that the list is a reference type, and changes to one variable affect the other.

### Illustration:
![Output Explanation](images/output_example.png)
