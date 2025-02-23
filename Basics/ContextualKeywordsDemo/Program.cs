namespace ContextualKeywordsDemo;


public partial class Program
{
    static async Task Main(string[] args)
    {
        await DisplayMessage();

        var number = 42;
        Console.WriteLine($"Number: {number}");

        dynamic value = "Hello";
        Console.WriteLine(value);
        value = 123;
        Console.WriteLine(value);

        foreach (var item in GetNumbers())
        {
            Console.WriteLine(item);
        }

        var query = from num in GetNumbers()
                    where num > 1
                    orderby num descending
                    select num;

        Console.WriteLine("Linq Query Result:");
        foreach (var num in query)
        {
            Console.WriteLine(num);
        }
    }

    static async Task DisplayMessage()
    {
        await Task.Delay(500);
        Console.WriteLine("Hello from an async method!");
    }

    static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }
}

public partial class Program
{
    // Example of 'partial' class usage
   //  public partial void PartialMethod();
}
