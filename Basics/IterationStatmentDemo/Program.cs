namespace IterationStatmentDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== FOR LOOP ===");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("For loop: " + i);
        }

        Console.WriteLine("\n=== WHILE LOOP ===");
        int w = 1;
        while (w <= 5)
        {
            Console.WriteLine("While loop: " + w);
            w++;
        }

        Console.WriteLine("\n=== DO...WHILE LOOP ===");
        int d = 1;
        do
        {
            Console.WriteLine("Do...While loop: " + d);
            d++;
        } while (d <= 5);

        Console.WriteLine("\n=== LOOP WITH BREAK AND CONTINUE ===");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even numbers

            if (i >= 9)
                break; // Stop at 9

            Console.WriteLine("Filtered loop: " + i);
        }

        Console.WriteLine("\nAll loops complete.");
    }
}
