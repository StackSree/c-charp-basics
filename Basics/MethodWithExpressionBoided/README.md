# MethodWithExpressionBoided

This C# console application demonstrates the usage of **expression-bodied members** introduced in C# 6.0 and enhanced in later versions like C# 7.0+. These members simplify your code by replacing traditional block-bodied definitions with more concise syntax.

## 🔧 Project Overview

The project contains a `Calculator` class that performs basic arithmetic and showcases different forms of expression-bodied members:

- Methods
- Properties
- Constructor
- Finalizer
- Indexer

---

## 📂 Program Structure

### `Main` Method

The entry point of the application creates a `Calculator` object and demonstrates its features:

```csharp
Calculator calc = new Calculator(5);
```

Then it prints results from several operations including addition, subtraction, and value manipulation.

---

## 📘 Calculator Class

### 1. **Expression-Bodied Methods**

These allow you to implement simple methods using `=>` instead of curly braces:

```csharp
public int Add(int a, int b) => a + b;
public int Subtract(int a, int b) => a - b;
```

✅ **Usage Benefit**: Cleaner, one-line syntax for simple operations.

---

### 2. **Expression-Bodied Read-Only Property**

```csharp
public string OperationDescription => "This class performs basic arithmetic.";
```

✅ **Usage Benefit**: Great for computed properties with a single return value.

---

### 3. **Expression-Bodied Property with Getter and Setter**

```csharp
public int Value
{
    get => _value * 2;
    set => _value = value;
}
```

✅ **Usage Benefit**: Lets you add logic in getters/setters without full method syntax.

---

### 4. **Expression-Bodied Constructor**

```csharp
public Calculator(int initialValue) => _value = initialValue;
```

✅ **Usage Benefit**: Compact constructor logic for simple assignments.

---

### 5. **Expression-Bodied Finalizer (Destructor)**

```csharp
~Calculator() => Console.WriteLine("Calculator object is being finalized.");
```

⚠️ **Note**: While syntactically allowed, destructors are rarely needed and this style should be used sparingly.

---

### 6. **Expression-Bodied Indexer**

```csharp
public string this[int index] => _messages[index];
```

✅ **Usage Benefit**: Simplifies the getter logic for accessing internal collections.

---

## 📈 Output Example

```
Addition: 5 + 3 = 8
Subtraction: 10 - 4 = 6
Description: This class performs basic arithmetic.
Value (doubled): 10
New Value (doubled): 20
Message at index 1: World
```

---

## 💡 Summary

This project is a practical demonstration of how to use **expression-bodied members** to make C# code more concise and readable, especially for simple operations.

> ✅ Best for: Simple logic
> ⚠️ Avoid for: Complex workflows or operations requiring error handling/debugging
