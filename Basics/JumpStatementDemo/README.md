# 🚀 C# break, continue, goto Statement, Jump Statements, return Statement, throw Statement Demo

This document demonstrates the usage of key jump statements in C# with simple examples.

## 🔹 1. `break` Statement

Used to exit a loop prematurely when a condition is met.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break; // Exit loop when i is 5
    Console.Write(i + " ");
}

✅ Output:
0 1 2 3 4


## 🔹 2. `continue` Statement

Skips the current iteration and jumps to the next one.

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
        continue; // Skip even numbers
    Console.Write(i + " ");
}

✅ Output:
1 3 5 7 9

## 🔹 3. goto Statement

Jumps to a labeled section in code. Use with caution as it can make code harder to follow.

int num = 3;
if (num == 3)
    goto CustomLabel;

Console.WriteLine("This will be skipped.");

CustomLabel:
Console.WriteLine("Jumped to CustomLabel!");

```

✅ Output:
Jumped to CustomLabel!

## 🔹 4. return Statement

Exits from a method and optionally returns a value.

static void ReturnExample()
{
Console.WriteLine("Inside ReturnExample method.");
return; // Exits method here
Console.WriteLine("This will not be printed.");
}

✅ Output:
Inside ReturnExample method.

## 🔹 5. throw Statement

Used to throw an exception manually.

static void ThrowExample()
{
throw new InvalidOperationException("This is a thrown exception!");
}

To handle it:

try
{
ThrowExample();
}
catch (Exception ex)
{
Console.WriteLine("Caught exception: " + ex.Message);
}

✅ Output:
Caught exception: This is a thrown exception!
