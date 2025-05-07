# Methods with access modifiers demo

This project demonstrates **access modifiers** in C# (`public`, `internal`, `private`, and `protected`) using inheritance and assembly-level access. It consists of a base class, a derived class, another unrelated class in the same assembly, and a `Main` method that illustrates accessibility rules in action.

## 📄 Description

The application shows how different types of class members (fields and methods) with various access modifiers can or cannot be accessed:

- From the base class itself
- From a derived class
- From another class in the same assembly
- From the `Main` method

## 📦 Assembly

Compiled as: `MySimpleDemo.dll`

## 🧱 Project Structure

- **`MyBaseClass`**
  Defines four fields and four methods with different access levels:

  - `public`
  - `internal`
  - `private`
  - `protected`

- **`MyDerivedClass : MyBaseClass`**
  Demonstrates which base members can be accessed from a derived class.

- **`AnotherClassInSameAssembly`**
  Shows what can be accessed from a non-derived class in the same assembly.

- **`Program`**
  Contains the `Main` method that runs all demonstrations.

## 🔍 Access Modifier Behavior

| Access Level | Base Class | Derived Class (same assembly) | Unrelated Class (same assembly) | `Main` Method |
| ------------ | ---------- | ----------------------------- | ------------------------------- | ------------- |
| `public`     | ✅ Yes     | ✅ Yes                        | ✅ Yes                          | ✅ Yes        |
| `internal`   | ✅ Yes     | ✅ Yes                        | ✅ Yes                          | ✅ Yes        |
| `protected`  | ✅ Yes     | ✅ Yes                        | ❌ No                           | ❌ No         |
| `private`    | ✅ Yes     | ❌ No                         | ❌ No                           | ❌ No         |

## ▶️ How to Run

1. Compile using a C# compiler:

   ```bash
   csc MySimpleDemo.cs -out:MySimpleDemo.exe
   ```

2. Run the executable:

   ```bash
   MySimpleDemo.exe
   ```

## 📌 Key Learning Points

- Understand how C# access modifiers affect visibility across classes and inheritance.
- Learn about the concept of assembly-level access (`internal`).
- See practical examples of access limitations enforced by the compiler.

## ✅ Output Example

The program outputs to the console, illustrating which fields and methods were accessible from each context.
