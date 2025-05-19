# Implicit Constructor Demo in C#

This C# console application demonstrates the concept of **implicit parameterless constructors** and how the presence of an explicit constructor affects constructor availability in user-defined classes.

---

## 📘 Overview

In C#, if **no constructor** is defined for a class, the compiler automatically provides a **public parameterless constructor**.

However, if a class defines **any constructor explicitly**, **no implicit parameterless constructor** is provided, and you must define it manually if needed.

---

## 🧪 Example Output

```bash
Demonstrating Implicit Parameterless Constructor:
Object 1 Value: 10
Object 3 Value: 20
```

---

## 📄 Code Explanation

### ✅ Class with Implicit Parameterless Constructor

```csharp
public class WithoutExplicitConstructor
{
    public int Value { get; set; }
    // No constructor defined — compiler adds a public parameterless constructor automatically.
}
```

### ❌ Class Without Parameterless Constructor

```csharp
public class WithExplicitConstructor
{
    public int Value { get; set; }

    public WithExplicitConstructor(int initialValue)
    {
        Value = initialValue;
    }

    // No parameterless constructor is added by the compiler here.
}
```

### Main Method Highlights

```csharp
WithoutExplicitConstructor obj1 = new WithoutExplicitConstructor(); // Works
WithExplicitConstructor obj3 = new WithExplicitConstructor(20);     // Works

// The following will cause a compile-time error if uncommented:
// WithExplicitConstructor obj2 = new WithExplicitConstructor();
```

---

### Steps

```bash
dotnet new console -n ImplicitConstructorDemo
cd ImplicitConstructorDemo
# Replace Program.cs content with the demo code
dotnet run
```

---

## 📚 Key Takeaways

- If **no constructor** is defined in a class, the compiler provides a **public parameterless constructor**.
- If a constructor is explicitly defined, the compiler does **not** add a default one.
- Attempting to use a parameterless constructor in such a case will result in a **compile-time error**.

---

## 📁 File Structure

```
/ImplicitConstructorDemo
  └── Program.cs     // Contains demo code for implicit and explicit constructors
  └── README.md      // This file
```

---

## 👨‍🏫 Author

This demo is intended for educational purposes to understand C# constructor behavior.
