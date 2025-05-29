namespace PropertiesDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Stock msft = new Stock();
        msft.CurrentPrice = 30;     // Calls set
        msft.CurrentPrice -= 3;     // Calls get then set

        Console.WriteLine(msft.CurrentPrice); // Calls get
    }
}

public class Stock
{
    private decimal currentPrice;

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
