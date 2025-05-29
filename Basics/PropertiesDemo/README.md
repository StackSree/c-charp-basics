# 📈 C# Properties – Simple Console App Demo

This project is a basic C# console application that demonstrates how **properties** work in C#. Properties provide controlled access to the internal fields of a class and are a key feature of encapsulation in object-oriented programming.

---

## 📚 What Are Properties?

Properties look like fields from the outside but internally use logic to **get** or **set** values. This gives the developer full control over how data is accessed and modified.

For example, this line:

```csharp
msft.CurrentPrice = 30;
```

Could be interacting with a simple backing field or a complex validation mechanism—**without the caller knowing the internal details**.

---

## 🏗️ Project Structure

```
/PropertiesDemo
├── Program.cs          # Main console entry point
└── Stock.cs            # Class with a property for demonstration
```

---

## ✅ Code Breakdown

### Stock.cs

```csharp
public class Stock
{
    private decimal currentPrice; // Backing field

    public decimal CurrentPrice
    {
        get { return currentPrice; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Price can't be negative.");
            currentPrice = value;
        }
    }
}
```

### Program.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        Stock msft = new Stock();
        msft.CurrentPrice = 30;     // Calls set accessor
        msft.CurrentPrice -= 3;     // Calls get + set

        Console.WriteLine(msft.CurrentPrice); // Calls get accessor
    }
}
```

---

## 🔍 What’s Happening Under the Hood?

When we write:

```csharp
msft.CurrentPrice -= 3;
```

It’s actually:

```csharp
decimal temp = msft.get_CurrentPrice();  // read
temp = temp - 3;                         // compute
msft.set_CurrentPrice(temp);            // write
```

So even though the syntax is field-like, **properties are actually methods in disguise**!

---

## 🧠 Why Use Properties?

- ✅ Encapsulation: hide internal implementation
- ✅ Validation: reject invalid values
- ✅ Compatibility: you can switch from field → property without changing API
- ✅ Debugging: insert breakpoints in `get`/`set`

---

## 🧪 Sample Output

```
27
```

---

## 🛠️ Requirements

- .NET 6.0 or later
- C# 8.0+

---

## 📌 Future Enhancements

- Add read-only or write-only properties
- Demonstrate auto-properties
- Log changes inside the setter
- Implement `INotifyPropertyChanged` (for WPF, Blazor, MAUI)

---

## 📚 Learn More

- [Properties (C# Programming Guide)](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- [Encapsulation in OOP](https://en.wikipedia.org/wiki/Encapsulation_%28computer_programming%29)

---

## 🧾 License

MIT – Free to use and modify.
