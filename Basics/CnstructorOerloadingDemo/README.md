# Constructor Overloading Demo in C#

This is a simple C# console application that demonstrates **constructor overloading** and how to chain constructors using the `this` keyword.

## 📌 Key Concepts

- **Constructor Overloading**: Multiple constructors with different parameter lists allow creating objects in various ways.
- **Constructor Chaining**: One constructor can call another to avoid duplicating initialization logic.
- **No Optional Parameters in Overloads with Same Signature**: Optional parameters cannot be combined with overloads that could lead to ambiguous calls.

## 📦 Class: Wine

```csharp
public class Wine
{
    public decimal Price;
    public int Year;

    // Constructor 1: Price only
    public Wine(decimal price)

    // Constructor 2: Price and year
    public Wine(decimal price, int year)

    // Constructor 3: Price and DateTime
    public Wine(decimal price, DateTime date)
}
```

### 🔄 Constructor Chaining

Each constructor uses the `this(...)` keyword to delegate to a simpler constructor:

```csharp
public Wine(decimal price, int year) : this(price) { ... }
public Wine(decimal price, DateTime date) : this(price, date.Year) { ... }
```

### ❌ Why Not Use Optional Parameters Here?

In C#, you **cannot define** two constructors like this:

```csharp
public Wine(decimal price, int year) { ... }
public Wine(decimal price, int year = 0) { ... } // ❌ CS0121: Ambiguous call
```

The compiler can't tell which constructor to use when you pass two arguments — both match. So, in this example, we avoid optional parameters entirely and use clear, distinct overloads instead.

## ▶️ Example Output

```
Demo 1:
Constructor with price called
Wine - Price: 29.99, Year: 0

Demo 2:
Constructor with price called
Constructor with price and year called
Wine - Price: 49.99, Year: 2020

Demo 3:
Constructor with price called
Constructor with price and year called
Constructor with price and DateTime called
Wine - Price: 59.99, Year: 2015
```

## ✅ Summary

- Use constructor overloading with clear parameter differences.
- Use `this(...)` for reusing constructor logic.
- Avoid combining overloads with optional parameters when the signatures can become ambiguous.
