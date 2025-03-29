# RefReturnsDemo

## Overview

This project demonstrates the use of **ref returns** in C#. The program includes a method that returns a reference to an element within an array, allowing modifications to be made directly to the array via the returned reference.

## Features

- Retrieves a reference to an element within an array.
- Allows modification of array elements through returned references.
- Handles out-of-bounds exceptions gracefully.

## Code Explanation

The program consists of the following components:

### 1. `GetReference(int[] array, int index)`

This method takes an array and an index as parameters and returns a reference to the specified element if the index is valid. If the index is out of bounds, an `IndexOutOfRangeException` is thrown.

### 2. `Main()` Method

- Initializes an integer array.
- Retrieves and modifies elements via reference returns.
- Demonstrates how changes to a reference affect the original array.
- Handles exceptions for out-of-bounds access attempts.

## Usage

### Steps to Run the Program

1. Compile and run the C# program using .NET SDK.
2. Observe how modifying elements via `ref` affects the original array.
3. Check the exception handling for invalid index access.

### Example Output

```sh
Original array: 1, 2, 3, 4, 5
Array after modifying third element via ref return: 1, 2, 100, 4, 5
Array after modifying first element via ref return: -5, 2, 100, 4, 5
Error: Index was outside the bounds of the array.
```

## Requirements

- .NET SDK installed
- C# 7.0 or later (as `ref returns` is introduced in C# 7.0)

## License

This project is open-source and available under the MIT License.
