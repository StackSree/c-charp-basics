# C# Assignment Operators Examples

## Overview

This program showcases how assignment operators work in C#. It provides examples and explanations for different assignments, including:

- Basic assignment (`=`)
- Compound assignments (`+=`, `-=`, `*=`, `/=`, `%=`, `&=`)
- Null-coalescing assignment (`??=`)
- Difference between assignment (`=`) and comparison (`==`)

## Code Explanation

### Simple Assignment

```csharp
int x;
x = 10;
Console.WriteLine($"x = 10; (x is now: {x})");
```

Assigns the value `10` to `x`.

```csharp
int a, b, c;
a = b = c = 20;
Console.WriteLine($"a = b = c = 20; (a:{a}, b:{b}, c:{c})");
```

All variables `a`, `b`, and `c` are assigned the value `20`.

### Compound Assignment

```csharp
counter += 3; // Equivalent to counter = counter + 3;
```

Performs addition assignment.

```csharp
counter %= 3; // Equivalent to counter = counter % 3;
```

Finds the remainder of `counter` divided by `3`.

### Bitwise Assignment

```csharp
bitwiseInt &= 3; // Performs bitwise AND assignment.
```

### Null-Coalescing Assignment

```csharp
string name = null;
name ??= "Guest";
```

If `name` is `null`, it is assigned "Guest".

### Comparison vs. Assignment

```csharp
if (num2 == 5)
```

Checks if `num2` is equal to `5`, avoiding accidental assignment (`=`) inside an `if` condition.

## How to Run the Code

1. Open a terminal or command prompt.
2. Navigate to the directory where the C# file is saved.
3. Compile the file using the C# compiler:
   ```sh
   csc Program.cs
   ```
4. Run the compiled executable:
   ```sh
   ./Program
   ```

## Conclusion

This program provides a clear understanding of assignment operators in C#. Run the code to see how each assignment works and observe the outputs.

---

Feel free to modify and experiment with the code to deepen your understanding!
