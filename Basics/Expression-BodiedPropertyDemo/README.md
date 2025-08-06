# C# Expression-Bodied Properties Demo

This project demonstrates the use of **expression-bodied properties** in C# through a simple `StockHolding` class. It includes both read-only and read/write properties, along with input validation and basic console output for clarity.

## 🧾 Features

- Expression-bodied **get-only** and **get/set** properties
- Safe property setters with exception handling
- Dynamic calculation of stock worth based on current price and shares owned
- Console-based interaction and demonstration

## 📦 Class: `StockHolding`

### Properties

| Property       | Type      | Access    | Description                                                             |
| -------------- | --------- | --------- | ----------------------------------------------------------------------- |
| `CurrentPrice` | `decimal` | get / set | The current price of a single share. Cannot be negative.                |
| `SharesOwned`  | `decimal` | get / set | Number of shares owned. Cannot be negative.                             |
| `WorthGetOnly` | `decimal` | get-only  | Calculates total worth. Expression-bodied, read-only.                   |
| `Worth`        | `decimal` | get / set | Expression-bodied get and set. Setting this recalculates `SharesOwned`. |

### Methods

- `DisplayDetails(string propertyName)`  
  Displays the current stock information using either the `WorthGetOnly` or `Worth` property.

## 🚀 Program Flow (in `Main`)

- Initializes a stock holding with a price of `$100` and `5` shares.
- Demonstrates:
  - Get-only property access
  - Updating shares and recalculating worth
  - Setting desired worth and auto-adjusting share count
  - Handling edge cases like zero price

## 📋 Example Output

```text
C# Expression-Bodied Property Demo

--- Using WorthGetOnly Property ---
Current Price: $100.00
Shares Owned: 5
Calculated Worth (Get-Only): $500.00
----------------------------------

Accessing WorthGetOnly directly: $500.00

--- Using Worth Property ---
Current Price: $100.00
Shares Owned: 5
Calculated Worth (Get/Set): $500.00
----------------------------------

Changing shares owned to 10...
--- Using Worth Property ---
Current Price: $100.00
Shares Owned: 10
Calculated Worth (Get/Set): $1,000.00
----------------------------------

Setting desired Worth to $2500.00...
--- Using Worth Property ---
Current Price: $100.00
Shares Owned: 25
Calculated Worth (Get/Set): $2,500.00
----------------------------------

Setting Current Price to $0.00...
--- Using Worth Property ---
Current Price: $0.00
Shares Owned: 25
Calculated Worth (Get/Set): $0.00
----------------------------------

Attempting to set Worth to $1000.00 with Current Price at $0.00...
Cannot set worth when current price is zero.
--- Using Worth Property ---
Current Price: $0.00
Shares Owned: 25
Calculated Worth (Get/Set): $0.00
----------------------------------

Demo Complete.
```

## 🛠️ Requirements

- .NET 6.0 SDK or higher
- C# 7.0 or higher (for expression-bodied members)

## 📁 File Structure

```
├── Program.cs
└── README.md
```

## 📚 Learn More

- [Expression-bodied members - Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members)
- [Properties in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)

---

Feel free to modify the source to experiment with more C# features like auto-properties, nullable types, or even async behavior.
