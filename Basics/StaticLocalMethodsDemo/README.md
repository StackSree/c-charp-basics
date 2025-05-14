# StaticLocalMethodsDemo

This C# demo showcases the behavior and differences between **static** and **non-static** local methods in various contexts within a method, including accessing variables, returning values, and passing parameters.

## 🧠 Concepts Covered

- Access to outer scope variables
- Static vs non-static local methods
- Parameter passing to local methods
- Returning values from local methods

---

## 🔧 How to Run

1. Copy the code from `StaticLocalMethodsDemo.cs` into your C# environment (e.g., Visual Studio, Visual Studio Code, or any C# compiler).
2. Run the program.
3. Observe the console output to understand how static and non-static local methods behave.

---

## 📋 Code Overview

### ✅ Example 1: Non-static Local Method

Demonstrates that non-static local methods **can access variables** from the outer scope.

```csharp
void NonStaticLocalMethod()
{
    Console.WriteLine($"  Outer variable: {outerVariable}");
}
```

---

### 🚫 Example 2: Static Local Method

Static local methods **cannot access** local variables from the enclosing method’s scope.

```csharp
static void StaticLocalMethod()
{
    Console.WriteLine("  Static local method cannot access outer variables.");
}
```

---

### 🧵 Example 3: Top-Level Statements and Local Methods

Non-static methods work as expected at the top level. Static methods still **cannot access outer variables**.

---

### 📥 Example 4: Static Method With Parameters

Shows how to **pass parameters** to a static local method to simulate access to needed data.

---

### 🔁 Example 5: Returning Values

- Non-static methods can access and use outer variables in return calculations.
- Static methods must work with passed-in parameters only.

---

## 🖨️ Sample Output

```text
Example 1: Non-static local method
  Outer variable: 10

Example 2: Static local method
  Static local method cannot access outer variables.
  Local variable inside StaticLocalMethod: 5

Example 3: Top-level statements and local methods
  Top-level variable from TopLevelLocalMethod: 30
  Static local method in top-level statements cannot access top-level variables.

Example 4: Passing parameters to static local method
  Parameter 1: 5, Parameter 2: 7

Example 5: Returning values from local methods
  Result from NonStaticReturningMethod: 18
  Result from StaticReturningMethod: 8
```

---

## 📚 Summary

| Feature                           | Non-static  | Static      |
| --------------------------------- | ----------- | ----------- |
| Access to outer local vars        | ✅          | ❌          |
| Can return values                 | ✅          | ✅          |
| Can accept parameters             | ✅          | ✅          |
| Used in performance-critical code | ❌ (slower) | ✅ (faster) |

---

## 📎 Notes

- Introduced in **C# 8.0**, static local methods improve performance by avoiding closures.
- Use static local methods when you **don’t need access to the enclosing context** and want to enforce isolation.

---

Feel free to copy or modify this code for learning or teaching purposes.
