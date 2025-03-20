# C# Arrays Demonstration

This project demonstrates the usage of **arrays** in C# with both **basic** and **advanced** techniques. It includes examples of:
- Single-dimensional arrays
- Multi-dimensional arrays
- Jagged arrays
- Sorting, reversing, and searching elements
- Copying and resizing arrays
- Using `List<T>` as a dynamic alternative to arrays

## Prerequisites

To run this project, ensure you have the following installed:
- **.NET SDK** (at least .NET Core 3.1 or later)
- **Visual Studio** or **Visual Studio Code**

## How to Run the Program

1. Clone or download this repository.
2. Open the project in **Visual Studio** or **VS Code**.
3. Copy and paste the `Program.cs` file content.
4. Run the program using:
   ```sh
   dotnet run
   ```

## Code Overview

### Basic Array Declaration & Initialization
```csharp
int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine("First Element: " + numbers[0]);
```

### Looping Through an Array
```csharp
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Element at index {i}: {numbers[i]}");
}
```

### Multi-Dimensional Array (2D Array)
```csharp
int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};
Console.WriteLine(matrix[1, 2]); // Output: 6
```

### Jagged Arrays (Array of Arrays)
```csharp
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 2 };
jaggedArray[1] = new int[] { 3, 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };
Console.WriteLine(jaggedArray[1][2]); // Output: 5
```

### Sorting an Array
```csharp
Array.Sort(numbers);
Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));
```

### Reversing an Array
```csharp
Array.Reverse(numbers);
Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));
```

### Using `List<T>` Instead of Arrays
```csharp
List<int> numList = new List<int> { 1, 2, 3 };
numList.Add(4);
numList.Remove(2);
Console.WriteLine("List: " + string.Join(", ", numList));
```

## Expected Output
```sh
==== Basic Array Declaration & Initialization ====
First Element: 10

==== Looping Through an Array ====
Element at index 0: 10
Element at index 1: 20
Element at index 2: 30
Element at index 3: 40
Element at index 4: 50
...
```
## License
This project is licensed under the MIT License - see the LICENSE file for details.

