# Variable and Parameter Demo

## Overview
This C# program demonstrates different types of variables, including:
- **Static Fields** (shared across all instances of a class)
- **Instance Fields** (unique to each instance of a class)
- **Local Variables** (declared within a method)
- **Method Parameters** (value, reference, output, and input parameters)
- **Array Elements** (modifying elements within an array)

## Code Structure
The program consists of the following key components:

### 1. **Static and Instance Fields**
- `staticField`: A static field shared across all instances of `VariableDemo`.
- `instanceField`: An instance field unique to each object.

### 2. **Local Variables**
- Demonstrated inside the `LocalVariableDemo` method.

### 3. **Method Parameters**
- `valueParam`: Passed by value (changes inside the method do not affect the original variable).
- `refParam`: Passed by reference (changes inside the method affect the original variable).
- `outParam`: Passed as an output parameter (must be assigned a value inside the method).
- `inParam`: Passed as a read-only reference (cannot be modified inside the method).

### 4. **Array Elements**
- Demonstrates modifying an element within an array inside the `ArrayElementDemo` method.

## Execution Flow
1. Creates an instance of `VariableDemo`.
2. Demonstrates the use of local variables.
3. Calls `ParameterDemo` to show different parameter types.
4. Displays instance and static fields.
5. Creates a second instance to show the difference between instance and static fields.
6. Demonstrates modifying an array element.

## Example Output
```
Local Variable: 20
In Parameter: 25
Value Parameter (inside method): 30
Ref Parameter (inside method): 40
Out Parameter (inside method): 60
Original Value (after method): 5
Ref Value (after method): 40
Out Value (after method): 60
Instance Field: 50
Static Field: 100
demo Instance Field: 50
demo2 Instance Field: 999
Static Field (both demos): 1000
Array Element myArray[1]: 77
```

## How to Run
1. Compile the program using the C# compiler:
   ```sh
   csc VariableDemo.cs
   ```
2. Run the executable:
   ```sh
   VariableDemo.exe
   ```

## Summary
This program effectively demonstrates variable types, parameter passing mechanisms, and the difference between instance and static members in C#. It provides a clear understanding of how variables behave in different contexts.

