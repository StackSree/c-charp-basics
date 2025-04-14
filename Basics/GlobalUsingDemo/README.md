# 🌍 Global Using Demo in C#

This project demonstrates the use of **Global Usings** in C#, introduced in .NET 6. Instead of repeating `using` directives in every file, you can define them once in a separate file (e.g., `GlobalUsings.cs`) and make them available across the entire project.

---

## 📂 Project Structure

```
GlobalUsingDemo/
├── Program.cs
└── GlobalUsings.cs
```

---

## 📄 GlobalUsings.cs

This file contains `global using` statements that apply to the entire project:

```csharp
global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
```

These cover common types used in the app like `Console`, `List<T>`, `Enumerable.First()`, and `StringBuilder`.

---

## 💻 Program.cs

This is the main entry point of the application, and it uses those global usings without needing to declare them at the top:

```csharp
namespace GlobalUsingDemo;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Count: {numbers.Count}");
        Console.WriteLine($"First number: {numbers.First()}");

        StringBuilder sb = new StringBuilder("Hello, ");
        sb.Append("world!");
        Console.WriteLine(sb.ToString());
    }
}
```

---

## ✅ Output

When you run the program, you'll see:

```
Count: 5
First number: 1
Hello, world!
```

---

## 🚀 How to Run

1. Make sure you have [.NET 6 or later](https://dotnet.microsoft.com/en-us/download) installed.
2. Clone or download this repo.
3. Navigate to the project directory and run:

```bash
dotnet run
```

---

## 🤔 Why Use Global Usings?

- Reduces repetitive `using` statements.
- Keeps code files cleaner and more focused.
- Especially helpful in larger projects and shared libraries.

---

## 📘 Learn More

- [Microsoft Docs: Global Using Directives](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/global-using-directives)
