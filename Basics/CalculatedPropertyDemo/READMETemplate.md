# 📊 CalculatedPropertyDemo

This C# console application demonstrates how to use **calculated** and **read-only** properties within a class. It simulates a simple stock holding tracker that calculates the total worth of owned stock based on the current price and number of shares.

---

## 📁 Project Structure

- `StockHolding.cs`
  Contains the `StockHolding` class with:

  - Validated `CurrentPrice` and `SharesOwned` properties.
  - A read-only calculated property `Worth` (total value).
  - A method `DisplayHoldingDetails()` to output stock information.

- `Program.cs`
  The main entry point that:

  - Creates a `StockHolding` instance.
  - Updates stock values.
  - Demonstrates how the calculated property `Worth` updates automatically.
  - Handles invalid input with exception handling.

---

## ✅ Features

- 🔒 **Read-only property** `Worth` is automatically computed from other properties.
- 🧮 **Calculated property** behavior: updates in real-time as dependent values change.
- ❌ **Validation**: Prevents setting negative values for price or shares.
- 💥 **Error handling**: Shows how invalid input is caught and managed gracefully.

---

## 🧪 Example Output

```
C# Demo: Read-Only and Calculated Properties

--- Stock Holding Details ---
Current Price per Share: $150.75
Shares Owned: 100
Total Worth: $15075.00
-----------------------------

Updating current price to $160.50...
--- Stock Holding Details ---
Current Price per Share: $160.50
Shares Owned: 100
Total Worth: $16050.00
-----------------------------

Updating shares owned to 120...
--- Stock Holding Details ---
Current Price per Share: $160.50
Shares Owned: 120
Total Worth: $19260.00
-----------------------------

Attempting to create a stock holding with negative price (will throw an error):
Error: Current price cannot be negative.

Press any key to exit.
```

---

## 🧠 Concepts Demonstrated

- **Encapsulation**: Backing fields with validation logic.
- **Calculated properties**: `Worth` is dynamically calculated.
- **Exception Handling**: Using `try-catch` to handle invalid input.
- **Immutability**: Prevents modification of `Worth` directly.

---

## 🛠 How to Run

1. Open the project in **Visual Studio** or any C# compatible IDE.
2. Build and run the project (`Ctrl + F5`).
3. Follow console output to understand how calculated properties behave.

---

## 🔐 Notes

- Attempting to directly assign a value to `Worth` (e.g., `myStock.Worth = 5000m`) will result in a **compile-time error**, because it is a read-only property.
- Decimal values are used to ensure precision in financial calculations.

---

## 📄 License

This project is provided for educational purposes. No license is applied.

---

Let me know if you’d like a version with Markdown formatting suitable for GitHub or a PDF version.
