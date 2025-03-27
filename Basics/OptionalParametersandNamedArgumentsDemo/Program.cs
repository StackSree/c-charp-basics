namespace OptionalParametersandNamedArgumentsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        OrderProcessor processor = new OrderProcessor();

        Console.WriteLine("Calling with all required and some optional parameters (positional):");
        processor.ProcessOrder(101, "Alice", 75, true);

        Console.WriteLine("\nCalling with only required parameters (positional):");
        processor.ProcessOrder(102, "Bob", 20);

        Console.WriteLine("\nCalling with named arguments for all parameters (different order):");
        processor.ProcessOrder(customerName: "Charlie", totalAmount: 120, orderId: 103, shippingAddress: "123 Main St");

        Console.WriteLine("\nCalling with a mix of positional and named arguments (skipping an optional parameter):");
        processor.ProcessOrder(104, "David", 50, shippingAddress: "456 Oak Ave");

        Console.WriteLine("\nCalling with only required and one specific optional parameter (named):");
        processor.ProcessOrder(105, "Eve", 99, isPriority: true);
    }

    public class OrderProcessor
    {
        public void ProcessOrder(int orderId, string customerName, decimal totalAmount, bool isPriority = false, string shippingAddress = "Default Address")
        {
            Console.WriteLine($"Order ID: {orderId}");
            Console.WriteLine($"Customer: {customerName}");
            Console.WriteLine($"Total Amount: {totalAmount:C}");
            Console.WriteLine($"Priority Order: {isPriority}");
            Console.WriteLine($"Shipping Address: {shippingAddress}");
            Console.WriteLine("-------------------------");
        }
    }
}
