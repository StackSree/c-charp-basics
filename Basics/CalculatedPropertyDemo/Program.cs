using System;

namespace CalculatedPropertyDemo
{
    // Define a class to represent a stock holding
    public class StockHolding
    {
        // Private backing fields for the properties
        private decimal _currentPrice;
        private decimal _sharesOwned;

        /// <summary>
        /// Gets or sets the current price per share.
        /// </summary>
        public decimal CurrentPrice
        {
            get { return _currentPrice; }
            set
            {
                // Ensure the price is not negative
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(CurrentPrice), "Current price cannot be negative.");
                }
                _currentPrice = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of shares owned.
        /// </summary>
        public decimal SharesOwned
        {
            get { return _sharesOwned; }
            set
            {
                // Ensure the number of shares is not negative
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(SharesOwned), "Shares owned cannot be negative.");
                }
                _sharesOwned = value;
            }
        }

        /// <summary>
        /// Gets the total worth of the stock holding.
        /// This is a read-only, calculated property.
        /// Its value is computed from CurrentPrice and SharesOwned.
        /// </summary>
        public decimal Worth
        {
            get { return CurrentPrice * SharesOwned; }
            // No 'set' accessor, making it read-only
        }

        /// <summary>
        /// Constructor to initialize a new StockHolding instance.
        /// </summary>
        /// <param name="price">The current price per share.</param>
        /// <param name="shares">The number of shares owned.</param>
        public StockHolding(decimal price, decimal shares)
        {
            CurrentPrice = price; // Use the property setter for validation
            SharesOwned = shares; // Use the property setter for validation
        }

        /// <summary>
        /// Displays the details of the stock holding.
        /// </summary>
        public void DisplayHoldingDetails()
        {
            Console.WriteLine($"--- Stock Holding Details ---");
            Console.WriteLine($"Current Price per Share: ${CurrentPrice:F2}"); // F2 for 2 decimal places
            Console.WriteLine($"Shares Owned: {SharesOwned:F0}"); // F0 for no decimal places
            Console.WriteLine($"Total Worth: ${Worth:F2}"); // Worth is calculated here
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Demo: Read-Only and Calculated Properties\n");

            // Create an instance of StockHolding
            StockHolding myStock = new StockHolding(150.75m, 100m);
            myStock.DisplayHoldingDetails();

            // Change the current price and observe the 'Worth' update automatically
            Console.WriteLine("Updating current price to $160.50...");
            myStock.CurrentPrice = 160.50m;
            myStock.DisplayHoldingDetails();

            // Change the number of shares and observe the 'Worth' update automatically
            Console.WriteLine("Updating shares owned to 120...");
            myStock.SharesOwned = 120m;
            myStock.DisplayHoldingDetails();

            // Attempting to set 'Worth' directly will result in a compile-time error
            // myStock.Worth = 5000m; // Uncommenting this line will cause a compile error:
            // "Property or indexer 'StockHolding.Worth' cannot be assigned to -- it is read only"

            Console.WriteLine("Attempting to create a stock holding with negative price (will throw an error):");
            try
            {
                StockHolding invalidStock = new StockHolding(-10m, 50m);
                invalidStock.DisplayHoldingDetails();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
