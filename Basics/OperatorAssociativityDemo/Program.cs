namespace OperatorAssociativityDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== Left-Associative Example ==");

        int result1 = 20 - 5 - 3; // (20 - 5) - 3 = 12
        Console.WriteLine("20 - 5 - 3 = " + result1);

        int result2 = 10 / 2 * 3; // (10 / 2) * 3 = 15
        Console.WriteLine("10 / 2 * 3 = " + result2);

        Console.WriteLine("\n== Right-Associative Example ==");

        int a, b;
        a = b = 5; // a = (b = 5)
        Console.WriteLine("a = b = 5 -> a = " + a + ", b = " + b);

        int? x = null;
        int? y = null;
        int? z = 7;
        int? result3 = x ?? y ?? z; // Right to left: x ?? (y ?? z)
        Console.WriteLine("x ?? y ?? z = " + result3);

        Console.WriteLine("\n== Ternary Operator Example ==");

        int num = 4;
        string result4 = (num < 5) ? "Less than 5" : "5 or more";
        Console.WriteLine("num < 5 ? ... : ... = " + result4);
    }
}
