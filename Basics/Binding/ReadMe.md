# Early Binding and Late Binding in C# (.NET Core)

This repository demonstrates **Early Binding** and **Late Binding** in **C# (.NET Core)** with practical examples.

## 📖 Overview

**Binding** refers to the process of connecting a method call to its corresponding method implementation. This can happen either at **compile-time (Early Binding)** or **runtime (Late Binding)**.

### 🔍 Key Differences

| Feature                | Early Binding                         | Late Binding                          |
|------------------------|---------------------------------------|---------------------------------------|
| **Decision Time**      | Compile-time                         | Runtime                               |
| **Performance**        | Faster                               | Slower due to runtime resolution      |
| **Type Checking**      | Done at compile-time                 | Done at runtime                       |
| **Flexibility**        | Less flexible; strongly typed         | More flexible; allows dynamic behavior|
| **Use Cases**          | Standard method calls, inheritance    | Reflection, dynamic types, COM objects|

## 🧱 Early Binding

Early binding is when the method to be called is determined at **compile-time**.

### ✅ Characteristics:
- Faster execution (resolved at compile-time).
- Strongly typed (compiler checks for errors).
- Common in regular method calls and inheritance.

### 📄 Example:

```csharp
using System;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Speak(); // Early binding

        Animal animal = new Animal();
        animal.Speak(); // Early binding
    }
}
```

## 🕵️ Late Binding

Late binding is when the method to be called is determined at **runtime**.

### ✅ Characteristics:
- Slower execution (resolved at runtime).
- Dynamic and flexible.
- Common in scenarios involving **Reflection** and the **dynamic** keyword.

### 📄 Example 1: Using Reflection

```csharp
using System;
using System.Reflection;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Late binding using reflection
        Type type = typeof(Animal);
        object obj = Activator.CreateInstance(type);
        MethodInfo method = type.GetMethod("Speak");

        method.Invoke(obj, null); // Invoke dynamically
    }
}
```

### 📄 Example 2: Using `dynamic`

```csharp
using System;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        dynamic animal = new Animal(); // Late binding
        animal.Speak(); // Resolved at runtime
    }
}
```

## 🚀 How to Run the Examples

Ensure you have **.NET Core SDK** installed on your system.

1. Clone the repository:

   ```bash
   git clone <repository-url>
   cd <repository-folder>
   ```

2. Run the examples:

   ```bash
   dotnet run
   ```

## 📚 References

- [Microsoft Docs: Reflection in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/reflection)
- [Dynamic Keyword in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/using-type-dynamic)

## 📌 License

This project is licensed under the MIT License.

