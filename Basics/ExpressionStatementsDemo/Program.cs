using System.Linq.Expressions;
using System.Text;

namespace ExpressionStatementsDemo;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== 1. Basic Expression Statements ===");
        BasicExpressionStatements();

        Console.WriteLine("\n=== 2. Expression in Control Flow ===");
        ControlFlowExpression();

        Console.WriteLine("\n=== 3. Expression-Bodied Members ===");
        var calc = new Calculator(5);
        Console.WriteLine($"Square of 5: {calc.Square}");

        Console.WriteLine("\n=== 4. Lambdas and LINQ ===");
        LambdaExpressionDemo();

        Console.WriteLine("\n=== 5. Async/Await Expression Statements ===");
        await AsyncExpressionDemo();

        Console.WriteLine("\n=== 6. Expression Trees ===");
        ExpressionTreeDemo();
    }

    static void BasicExpressionStatements()
    {
        int x = 10;
        int y = 5;

        x = x + y;       // Assignment expression
        x++;             // Increment
        Console.WriteLine($"x: {x}, y: {y}"); // Method call

        var sb = new StringBuilder();         // Assignment + object instantiation
        new StringBuilder();                  // Legal but useless

        "hello".ToUpper();                    // Legal but useless

        x.Equals(y);                          // Legal but result is discarded
    }

    static void ControlFlowExpression()
    {
        var lines = new List<string> { "one", "two", "three" };
        string line;
        int i = 0;

        while ((line = lines.ElementAtOrDefault(i++)) != null)
        {
            Console.WriteLine(line); // Expression statement inside loop
        }
    }

    // 3. Expression-bodied member in a class
    class Calculator
    {
        private int _x;
        public Calculator(int x) => _x = x;
        public int Square => _x * _x; // Expression-bodied property
    }

    static void LambdaExpressionDemo()
    {
        var numbers = new List<int> { 1, 2, 3 };

        // Lambda with expression statement inside
        numbers.ForEach(n => Console.WriteLine(n));

        // LINQ with lambda expression
        var squares = numbers.Select(n => n * n);
        foreach (var s in squares)
            Console.WriteLine($"Square: {s}");
    }

    static async Task AsyncExpressionDemo()
    {
        // Note: Only works if you're online and have a valid URL
        using var client = new HttpClient();

        try
        {
            string content = await client.GetStringAsync("https://www.example.com");
            Console.WriteLine("Downloaded content length: " + content.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Download failed: " + ex.Message);
        }
    }

    static void ExpressionTreeDemo()
    {
        // This doesn't execute, it builds an expression tree
        Expression<Func<int, int>> expr = x => x * x;

        Console.WriteLine("Expression Tree:");
        Console.WriteLine(expr);

        // Compile and execute it dynamically
        var func = expr.Compile();
        Console.WriteLine($"Result of func(5): {func(5)}");
    }
}
