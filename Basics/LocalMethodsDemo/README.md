# 🧾 Order Processing with Local Methods in C\#

This C# console application demonstrates the **real-time use of local methods** within a class method. It simulates a basic **order processing system** with subtotal, tax, and total calculations, using local methods for better organization, readability, and encapsulation.

---

## 📌 Key Concepts

### ✅ **Local Methods in C#**

Local methods are functions **declared inside another method**, introduced in C# 7.0. They:

- Improve **code organization** by grouping related logic close to its usage.
- Provide **encapsulation**, keeping helper methods hidden from the rest of the class.
- Can access **outer method variables** and class members (like fields and properties).

---

## 📦 Project Structure

### `OrderItem` Class

```csharp
public class OrderItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
```

Represents an item in an order, including its name, unit price, and quantity.

---

### `OrderProcessor` Class

Handles order processing logic and demonstrates **local methods**.

```csharp
public void ProcessOrder(List<OrderItem> items, string customerName)
```

This method performs the following:

1. ✅ **Prints the customer's name**
2. ✅ **Calculates subtotal**
3. ✅ **Computes tax**
4. ✅ **Displays an order summary**

All using **local methods**, defined within `ProcessOrder`.

---

## 🔍 Local Methods in Action

### 1. **`CalculateSubtotal`**

Calculates the total before tax:

```csharp
decimal CalculateSubtotal(List<OrderItem> orderItems)
{
    decimal sum = 0;
    foreach (var item in orderItems)
    {
        sum += item.Price * item.Quantity;
    }
    return sum;
}
```

🔹 **Real-world use**: Keeps pricing logic close to order processing, avoiding exposure outside the method.

---

### 2. **`CalculateTax`**

Computes tax using the class-level `_taxRate`:

```csharp
decimal CalculateTax(decimal amount) => amount * _taxRate;
```

🔹 **Real-world use**: Encourages reuse and avoids repeating tax logic throughout the code.

---

### 3. **`DisplayOrderSummary`**

Prints itemized billing and totals:

```csharp
void DisplayOrderSummary(List<OrderItem> orderItems, decimal sub, decimal taxAmount, decimal totalAmount)
{
    Console.WriteLine("\n--- Order Details ---");
    foreach (var item in orderItems)
    {
        Console.WriteLine($"{item.Quantity} x {item.Name} @ ${item.Price} = ${item.Price * item.Quantity}");
    }
    Console.WriteLine($"Subtotal: ${sub:F2}");
    Console.WriteLine($"Tax ({_taxRate * 100}%): ${taxAmount:F2}");
    Console.WriteLine($"Total: ${totalAmount:F2}");
    Console.WriteLine("---------------------");
}
```

🔹 **Real-world use**: Great for formatting output or generating reports tied directly to the current transaction.

---

## 🧪 Sample Output

```plaintext
Processing order for: Alice Smith

--- Order Details ---
1 x Laptop @ $1200.00 = $1200.00
2 x Mouse @ $25.00 = $50.00
Subtotal: $1250.00
Tax (8%): $100.00
Total: $1350.00
---------------------
```

---

## 💡 Why Use Local Methods?

| Feature               | Benefit                                                   |
| --------------------- | --------------------------------------------------------- |
| Closer to usage point | Easier to understand and maintain                         |
| Access to local scope | Can use method parameters and local variables directly    |
| Encapsulation         | Keeps helper logic hidden from the rest of the class      |
| Readability           | Avoids bloating the class with many small utility methods |

---

## 🧰 Technologies Used

- **Language**: C#
- **Concepts**: Local methods, object-oriented programming, encapsulation

---

## 📚 Learn More

- [Microsoft Docs: Local Functions in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions)
- [C# 7.0 Features Overview](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7)

---

## ✅ Summary

This project is a practical and real-time demonstration of how **local methods** make C# code more readable and maintainable—especially useful for processing data, performing calculations, and organizing business logic within a method.
