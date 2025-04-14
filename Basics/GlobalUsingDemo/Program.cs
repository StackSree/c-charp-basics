namespace GlobalUsingDemo;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Count: {numbers.Count}");
        Console.WriteLine($"First number: {numbers.First()}");
        StringBuilder sb = new StringBuilder("Hello, ");
        sb.Append("world!");
        Console.WriteLine(sb.ToString());
    }
}
