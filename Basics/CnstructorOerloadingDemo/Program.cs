namespace CnstructorOerloadingDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demo 1:");
        Wine wine1 = new Wine(29.99m);
        wine1.Display();

        Console.WriteLine("\nDemo 2:");
        Wine wine2 = new Wine(49.99m, 2020);
        wine2.Display();

        Console.WriteLine("\nDemo 3:");
        Wine wine3 = new Wine(59.99m, new DateTime(2015, 1, 1));
        wine3.Display();

        Console.WriteLine("\nDemo 4 (optional parameter):");
        Wine wine4 = new Wine(39.99m); // Year will default to 0
        wine4.Display();
    }

    public class Wine
    {
        public decimal Price;
        public int Year;

        // Constructor 1: Only price
        public Wine(decimal price)
        {
            Price = price;
            Console.WriteLine("Constructor with price called");
        }

        // Constructor 2: Price and year
        public Wine(decimal price, int year) : this(price)
        {
            Year = year;
            Console.WriteLine("Constructor with price and year called");
        }

        // Constructor 3: Price and DateTime (extracts year)
        public Wine(decimal price, DateTime date) : this(price, date.Year)
        {
            Console.WriteLine("Constructor with price and DateTime called");
        }

        public void Display()
        {
            Console.WriteLine($"Wine - Price: {Price}, Year: {Year}");
        }
    }
}
