using System.Text;

namespace NullOperatorsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Null-Coalescing Operator (??) ===");
        string s1 = null;
        string s2 = s1 ?? "nothing";
        Console.WriteLine($"s2 = {s2}");

        int? nullableInt = null;
        int value = nullableInt ?? 42;
        Console.WriteLine($"value = {value}");

        Console.WriteLine("\n=== Null-Coalescing Assignment Operator (??=) ===");
        string name = null;
        name ??= "Default Name";
        Console.WriteLine($"name = {name}");

        StringBuilder sb = null;
        sb ??= new StringBuilder("Initialized");
        Console.WriteLine($"sb = {sb.ToString()}");

        Console.WriteLine("\n=== Null-Conditional Operator (?.) ===");
        StringBuilder sb2 = null;
        string result = sb2?.ToString();
        Console.WriteLine($"sb2?.ToString() = {result}");

        string[] words = null;
        string word = words?[1];
        Console.WriteLine($"words?[1] = {word}");

        int? length = sb2?.ToString().Length;
        Console.WriteLine($"length = {length}");

        Console.WriteLine("\n=== Combining ?. and ?? ===");
        StringBuilder sb3 = null;
        string final = sb3?.ToString() ?? "nothing";
        Console.WriteLine($"final = {final}");

        Console.WriteLine("\n=== ?. with void methods ===");
        Dummy obj = null;
        obj?.SayHello(); // No exception
    }

    class Dummy
    {
        public void SayHello() => Console.WriteLine("Hello!");
    }
}
