# Nullable Reference Types in C#

## Overview
C# 8.0 introduced **Nullable Reference Types (NRTs)** to help prevent null reference exceptions by distinguishing between nullable and non-nullable references at compile time.

This demo showcases how enabling NRTs can improve code safety by making nullability explicit.

## Enabling Nullable Reference Types
To enable this feature, add the following line to your `.csproj` file inside a `<PropertyGroup>` tag:

```xml
<Nullable>enable</Nullable>

## Code.

using System;

public class NullableReferenceTypesDemo
{
    public static void Main(string[] args)
    {
        string? nullableString = null;
        if (nullableString == null)
        {
            Console.WriteLine("Nullable String is null.");
        }

        string lengthString = nullableString?.Length.ToString();
        Console.WriteLine($"Length String: {lengthString}");

        Person? person = null;
        if (person == null)
        {
            Console.WriteLine("Person object is null");
        }

        Person person2 = new Person { Name = "Alice" };
        Console.WriteLine($"Person2's name: {person2.Name}");
    }

    public class Person
    {
        public string Name { get; set; } = ""; // Ensures Name is initialized.
    }
}

## Key Concepts Demonstrated
Traditional null handling (prone to runtime exceptions).
Explicit nullable and non-nullable references.
Safe navigation (?.) and null-forgiving (!) operators.
Handling nullable properties in classes.

## Benefits of Using Nullable Reference Types
✅ Compile-time safety – Catch null-related issues early.
✅ Better code clarity – Explicitly state whether a variable can be null.
✅ Reduced runtime exceptions – Avoid the infamous NullReferenceException.

## Learn More
Microsoft Docs: Nullable Reference Types
C# 8.0 Features