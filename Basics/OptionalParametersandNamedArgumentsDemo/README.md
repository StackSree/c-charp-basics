# Optional Parameters and Named Arguments Demo

## Overview
This C# project demonstrates the use of optional parameters and named arguments in method calls. The program includes an `OrderProcessor` class with a `ProcessOrder` method that accepts required and optional parameters.

## Features
- Calls a method with different combinations of required and optional parameters.
- Demonstrates positional and named argument usage.
- Shows how default parameter values can be utilized.

## Code Structure
The project contains:
- `Program` class with the `Main` method to test different method calls.
- `OrderProcessor` class with a `ProcessOrder` method that accepts order details, including optional parameters for priority status and shipping address.

## Usage
The `ProcessOrder` method has the following signature:
```csharp
public void ProcessOrder(int orderId, string customerName, decimal totalAmount, bool isPriority = false, string shippingAddress = "Default Address")
```
### Method Parameters:
- `orderId` (required): Unique order identifier.
- `customerName` (required): Name of the customer placing the order.
- `totalAmount` (required): Total order cost.
- `isPriority` (optional, default: `false`): Indicates whether the order is a priority.
- `shippingAddress` (optional, default: `"Default Address"`): Address for shipping the order.

### Example Calls:
1. **Using all required and some optional parameters (positional arguments):**
   ```csharp
   processor.ProcessOrder(101, "Alice", 75, true);
   ```
2. **Using only required parameters (positional arguments):**
   ```csharp
   processor.ProcessOrder(102, "Bob", 20);
   ```
3. **Using named arguments in a different order:**
   ```csharp
   processor.ProcessOrder(customerName: "Charlie", totalAmount: 120, orderId: 103, shippingAddress: "123 Main St");
   ```
4. **Mixing positional and named arguments while skipping an optional parameter:**
   ```csharp
   processor.ProcessOrder(104, "David", 50, shippingAddress: "456 Oak Ave");
   ```
5. **Using only required parameters and one specific optional parameter (named):**
   ```csharp
   processor.ProcessOrder(105, "Eve", 99, isPriority: true);
   ```

## Output
The program prints the order details to the console, showcasing how different argument combinations work.

## Requirements
- .NET SDK
- C# Compiler

## Running the Program
1. Compile the program:
   ```sh
   dotnet build
   ```
2. Run the program:
   ```sh
   dotnet run
   ```

## Conclusion
This project demonstrates the power of optional parameters and named arguments in C#. It helps in writing flexible and readable method calls while making use of default parameter values efficiently.


