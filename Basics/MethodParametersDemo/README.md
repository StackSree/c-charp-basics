# C# Method Parameters

## Overview
In C#, a method may have a sequence of parameters that define the set of arguments that must be provided for that method. This allows data to be passed into methods for processing.

### Example
```csharp
Foo(8); // 8 is an argument

static void Foo(int p)
{
    Console.WriteLine(p);
} // p is a parameter
```

## Parameter Modifiers in C#
C# provides different ways to pass parameters using modifiers:

| Parameter Modifier | Passed By | Variable Must Be Assigned |
|--------------------|-----------|---------------------------|
| (None)            | Value      | Going in                 |
| ref               | Reference  | Going in                 |
| in                | Reference (read-only) | Going in     |
| out               | Reference  | Going out                 |

### Examples
#### **Passing by Value (Default)**
```csharp
static void PassByValue(int x)
{
    x = 10;
    Console.WriteLine($"Inside method: {x}");
}

int a = 5;
PassByValue(a);
Console.WriteLine($"Outside method: {a}"); // Output: 5
```

#### **Passing by Reference using `ref`**
```csharp
static void PassByRef(ref int x)
{
    x = 10;
}

int a = 5;
PassByRef(ref a);
Console.WriteLine(a); // Output: 10
```

#### **Passing Read-Only Reference using `in`**
```csharp
static void ReadOnlyRef(in int x)
{
    Console.WriteLine(x);
    // x = 10; // Compilation error
}

int a = 5;
ReadOnlyRef(in a);
```

#### **Using `out` for Output Parameters**
```csharp
static void GetValues(out int x, out int y)
{
    x = 10;
    y = 20;
}

int a, b;
GetValues(out a, out b);
Console.WriteLine($"a: {a}, b: {b}"); // Output: a: 10, b: 20
```

## Demo
You can run the following interactive C# console program to test the different parameter modifiers:
```csharp
using System;

class Program
{
    static void Main()
    {
        int value = 5;
        PassByValue(value);
        Console.WriteLine($"PassByValue: {value}");

        PassByRef(ref value);
        Console.WriteLine($"PassByRef: {value}");

        ReadOnlyRef(in value);
        Console.WriteLine($"ReadOnlyRef: {value}");

        GetValues(out int x, out int y);
        Console.WriteLine($"GetValues: x={x}, y={y}");
    }

    static void PassByValue(int x)
    {
        x = 10;
    }

    static void PassByRef(ref int x)
    {
        x = 10;
    }

    static void ReadOnlyRef(in int x)
    {
        Console.WriteLine(x);
    }

    static void GetValues(out int x, out int y)
    {
        x = 10;
        y = 20;
    }
}
```

## Conclusion
Understanding how parameters work and how to control how they are passed can help in writing efficient and optimized C# code. The `ref`, `in`, and `out` modifiers provide additional control over data manipulation and memory management.

