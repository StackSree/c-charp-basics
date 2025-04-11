namespace JumpStatementDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Break Statement:");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
                break; // Exit loop when i is 5
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("2. Continue Statement:");
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even numbers
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("3. Goto Statement:");
        int num = 3;
        if (num == 3)
            goto CustomLabel;

        Console.WriteLine("This will be skipped.");

    CustomLabel:
        Console.WriteLine("Jumped to CustomLabel!\n");

        Console.WriteLine("4. Return Statement:");
        ReturnExample();
        Console.WriteLine("This line will not be printed.\n");

        Console.WriteLine("5. Throw Statement:");
        try
        {
            ThrowExample();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught exception: " + ex.Message);
        }
    }

    static void ReturnExample()
    {
        Console.WriteLine("Inside ReturnExample method.");
        return; // Exits the method
        Console.WriteLine("Unreachable code.");
    }

    static void ThrowExample()
    {
        throw new InvalidOperationException("This is a thrown exception!");
    }
}

