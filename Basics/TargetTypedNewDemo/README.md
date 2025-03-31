# Target-Typed New Expressions in C#

## Overview

This project demonstrates the use of **target-typed `new` expressions** in C# 9 and later. The `TargetTypedNewDemo` class showcases how the `new` keyword can infer the type from the context, reducing redundancy in code and improving readability.

## Features

- Uses **target-typed `new`** in field initialization, local variable assignment, constructor calls, and method arguments.
- Demonstrates how `new` can be used without explicitly specifying the type when it's already known from the declaration.
- Compares concise `new` expressions with traditional verbose syntax.

## Code Breakdown

### Target-Typed `new` in Various Scenarios

1. **Field Initialization in a Constructor:**

   ```csharp
   private StringBuilder fieldBuilder;
   fieldBuilder = new (initialValue); // Implicitly inferred as StringBuilder
   ```

2. **Local Variable Declaration and Initialization:**

   ```csharp
   StringBuilder sb1 = new(); // No need to specify 'StringBuilder' again
   StringBuilder sb2 = new("Test");
   ```

   Equivalent verbose syntax:

   ```csharp
   StringBuilder sb3 = new StringBuilder();
   StringBuilder sb4 = new StringBuilder("Another Test");
   ```

3. **Constructor Usage:**

   ```csharp
   TargetTypedNewDemo demo = new("Initial Value in Constructor");
   ```

4. **Method Argument Usage:**
   ```csharp
   MyMethod(new("Argument String"));
   ```
   Equivalent verbose syntax:
   ```csharp
   MyMethod(new StringBuilder("Verbose Argument"));
   ```

## Running the Program

### Prerequisites

- .NET SDK 5.0 or later (C# 9+)

### Steps

1. **Build the project:**
   ```sh
   dotnet build
   ```
2. **Run the program:**
   ```sh
   dotnet run
   ```

## Benefits of Target-Typed `new`

✅ **Reduces redundancy** – No need to repeat the type name when it can be inferred.
✅ **Improves readability** – Cleaner and more concise code.
✅ **Enhances maintainability** – Less duplication makes refactoring easier.

🚀 Start using **target-typed `new`** in your C# projects to write cleaner and more expressive code!
