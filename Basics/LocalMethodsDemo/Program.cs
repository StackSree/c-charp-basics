namespace LocalMethodsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        var processor = new OrderProcessor(0.08m); // 8% tax rate
        var orderItems = new List<OrderItem>
        {
            new OrderItem { Name = "Laptop", Price = 1200.00m, Quantity = 1 },
            new OrderItem { Name = "Mouse", Price = 25.00m, Quantity = 2 }
        };

        processor.ProcessOrder(orderItems, "Alice Smith");
    }
}
public class OrderItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class OrderProcessor
{
    private decimal _taxRate;

    public OrderProcessor(decimal taxRate)
    {
        _taxRate = taxRate;
    }

    public void ProcessOrder(List<OrderItem> items, string customerName)
    {
        Console.WriteLine($"Processing order for: {customerName}");

        decimal subtotal = CalculateSubtotal(items);
        decimal tax = CalculateTax(subtotal);
        decimal total = subtotal + tax;

        DisplayOrderSummary(items, subtotal, tax, total);

        // Local method to calculate the subtotal
        decimal CalculateSubtotal(List<OrderItem> orderItems)
        {
            decimal sum = 0;
            foreach (var item in orderItems)
            {
                sum += item.Price * item.Quantity;
            }
            return sum;
        }

        // Local method to calculate the tax (accessing the outer _taxRate field)
        decimal CalculateTax(decimal amount) => amount * _taxRate;

        // Local method to display the order summary (accessing local variables)
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
    }
}