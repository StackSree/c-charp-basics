# Method Overloading Demo in C#

This console application demonstrates various rules and behaviors related to **method overloading** in C#. It is useful for learning how method signatures affect overloads, and what kinds of overloads are allowed or disallowed by the C# compiler.

## 📘 Overview

In C#, a method can be overloaded if it has a **unique signature** — this includes method name, number of parameters, type of parameters, and parameter modifiers like `ref` and `out`.

This application shows:

- ✅ Valid overloads (e.g., different types, number of parameters)
- ❌ Invalid overloads (e.g., differing only by return type or conflicting use of `params`)
- ⚠️ Rules for `ref` and `out` modifiers

---

## 🧪 Example Output

```bash
Method Overloading Demo
Foo(int)
Foo(double)
Foo(int, float)
Foo(float, int)
Foo(ref int)
After ref Foo: 15
```

---

## 📄 Code Highlights

### ✅ Valid Overloads

```csharp
static void Foo(int x)
static void Foo(double x)
static void Foo(int x, float y)
static void Foo(float x, int y)
static void Foo(ref int x)
```

### ❌ Invalid Overloads (Commented out in the code)

```csharp
// float Foo(int x)                         // Invalid: Only return type differs
// static void Goo(int[] x)
// static void Goo(params int[] x)         // Invalid: params conflicts with array
// static void Foo(out int x)              // Invalid with Foo(ref int x)
```

---

## 📚 Learning Notes

- Return type is **not** part of the method signature.
- `params` is part of the method signature — so `params int[]` conflicts with `int[]`.
- `ref` and `out` are part of the signature. You can have `Foo(ref int)` and `Foo(int)`, but not both `ref` and `out` with the same parameter type.
- Local methods (declared inside top-level statements) **cannot** be overloaded.

## 👨‍🏫 Author

Created as a sample educational project to demonstrate method overloading principles in C#.
