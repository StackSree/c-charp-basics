namespace AssignmentDemo;

internal class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("--- Simple Assignment ---");
        int x;
        x = 10;
        Console.WriteLine($"x = 10; (x is now: {x})");

        int a, b, c;
        a = b = c = 20;
        Console.WriteLine($"a = b = c = 20; (a:{a}, b:{b}, c:{c})");

        int y = 5;
        int result = y = 15; // Assignment returns the assigned value
        Console.WriteLine($"int result = y = 15; (y is now: {y}, result is: {result})");

        Console.WriteLine("\n--- Compound Assignment ---");
        int counter = 5;
        Console.WriteLine($"Initial counter: {counter}");

        counter += 3; // Equivalent to counter = counter + 3;
        Console.WriteLine($"counter += 3; (counter is now: {counter})");

        counter -= 2; // Equivalent to counter = counter - 2;
        Console.WriteLine($"counter -= 2; (counter is now: {counter})");

        counter *= 4; // Equivalent to counter = counter * 4;
        Console.WriteLine($"counter *= 4; (counter is now: {counter})");

        counter /= 2; // Equivalent to counter = counter / 2;
        Console.WriteLine($"counter /= 2; (counter is now: {counter})");

        counter %= 3; // Equivalent to counter = counter % 3;
        Console.WriteLine($"counter %= 3; (counter is now: {counter})");

        int bitwiseInt = 5; // Binary: 0101
        bitwiseInt &= 3;    // Binary: 0011 (5 & 3 = 1)
        Console.WriteLine($"bitwiseInt &= 3; (bitwiseInt is now: {bitwiseInt})");

        Console.WriteLine("\n--- Null-Coalescing Assignment ---");
        string name = null;
        Console.WriteLine($"Initial name: {name ?? "null" : name}");

        name ??= "Guest";
        Console.WriteLine($"name ??= \"Guest\"; (name is now: {name})");

        string greeting = "Hello";
        Console.WriteLine($"Initial greeting: {greeting?? "null" : greeting}");

        greeting ??= "Welcome";
        Console.WriteLine($"greeting ??= \"Welcome\"; (greeting is now: {greeting})");

        Console.WriteLine("\n--- Important Note: Comparison vs. Assignment ---");
        int num1 = 10;
        // The following line is an assignment, not a comparison!
        // if (num1 = 5) // This would cause a compile-time error because the result of the assignment (5) cannot be implicitly converted to bool.

        int num2 = 10;
        if (num2 == 5)
        {
            Console.WriteLine("num2 is equal to 5 (This won't be printed)");
        }
        else
        {
            Console.WriteLine("num2 is not equal to 5");
        }
    }
}

