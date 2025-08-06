namespace Expression_BodiedPropertyDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# Expression-Bodied Property Demo\n");

        // Create a new stock holding
        StockHolding myStock = new StockHolding(100.00m, 5m);
        myStock.DisplayDetails("WorthGetOnly");

        // Demonstrate the read-only expression-bodied property
        Console.WriteLine($"Accessing WorthGetOnly directly: {myStock.WorthGetOnly:C}\n");

        // Demonstrate the expression-bodied property with both get and set
        myStock.DisplayDetails("Worth");

        // Change shares and see Worth update (via get)
        Console.WriteLine("Changing shares owned to 10...");
        myStock.SharesOwned = 10m;
        myStock.DisplayDetails("Worth");

        // Set a desired worth and see shares update (via set)
        Console.WriteLine("Setting desired Worth to $2500.00...");
        myStock.Worth = 2500.00m; // This will update myStock.SharesOwned
        myStock.DisplayDetails("Worth");

        // Try setting worth with zero price
        Console.WriteLine("Setting Current Price to $0.00...");
        myStock.CurrentPrice = 0m;
        myStock.DisplayDetails("Worth");

        Console.WriteLine("Attempting to set Worth to $1000.00 with Current Price at $0.00...");
        myStock.Worth = 1000.00m; // This will trigger the console warning
        myStock.DisplayDetails("Worth");

        Console.WriteLine("\nDemo Complete.");
    }
}

public class StockHolding
{
    // Private fields to store the actual data
    private decimal _currentPrice;
    private decimal _sharesOwned;

    // Public property for CurrentPrice with a standard get/set
    public decimal CurrentPrice
    {
        get => _currentPrice;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(CurrentPrice), "Price cannot be negative.");
            }
            _currentPrice = value;
        }
    }

    // Public property for SharesOwned with a standard get/set
    public decimal SharesOwned
    {
        get => _sharesOwned;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(SharesOwned), "Shares cannot be negative.");
            }
            _sharesOwned = value;
        }
    }

    // Constructor to initialize the stock holding
    public StockHolding(decimal price, decimal shares)
    {
        CurrentPrice = price;
        SharesOwned = shares;
    }

    // --- Expression-bodied GET accessor for Worth ---
    // This is a read-only property. It calculates the worth whenever it's accessed.
    // Equivalent to: public decimal Worth { get { return _currentPrice * _sharesOwned; } }
    public decimal WorthGetOnly => _currentPrice * _sharesOwned;

    // --- Expression-bodied GET and SET accessors for Worth ---
    // This property allows both reading the worth and setting a desired worth,
    // which then updates the underlying _sharesOwned.
    public decimal Worth
    {
        // The 'get' accessor is expression-bodied
        get => _currentPrice * _sharesOwned;
        // The 'set' accessor is also expression-bodied
        // 'value' is a contextual keyword representing the value being assigned to the property
        set
        {
            if (_currentPrice > 0)
            {
                _sharesOwned = value / _currentPrice;
            }
            else
            {
                // Handle case where current price is zero to avoid division by zero
                Console.WriteLine("Cannot set worth when current price is zero.");
            }
        }
    }

    // Method to display current stock holding details
    public void DisplayDetails(string propertyName)
    {
        Console.WriteLine($"--- Using {propertyName} Property ---");
        Console.WriteLine($"Current Price: {CurrentPrice:C}");
        Console.WriteLine($"Shares Owned: {SharesOwned}");
        if (propertyName == "WorthGetOnly")
        {
            Console.WriteLine($"Calculated Worth (Get-Only): {WorthGetOnly:C}");
        }
        else if (propertyName == "Worth")
        {
            Console.WriteLine($"Calculated Worth (Get/Set): {Worth:C}");
        }
        Console.WriteLine("----------------------------------");
    }
}