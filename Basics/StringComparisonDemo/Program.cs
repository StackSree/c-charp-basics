namespace StringComparisonDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // --- Equality Comparisons ---
        Console.WriteLine("--- Equality Comparisons ---");

        string str1 = "hello";
        string str2 = "hello";
        string str3 = "Hello";

        Console.WriteLine($"String 1: \"{str1}\"");
        Console.WriteLine($"String 2: \"{str2}\"");
        Console.WriteLine($"String 3: \"{str3}\"");
        Console.WriteLine();

        // Using the == operator
        bool isEqual1 = (str1 == str2);
        Console.WriteLine($"str1 == str2: {isEqual1}"); // Output: True

        bool isEqual2 = (str1 == str3);
        Console.WriteLine($"str1 == str3 (case-sensitive): {isEqual2}"); // Output: False

        // Using the Equals() method (case-sensitive by default)
        bool isEqual3 = str1.Equals(str2);
        Console.WriteLine($"str1.Equals(str2): {isEqual3}"); // Output: True

        bool isEqual4 = str1.Equals(str3);
        Console.WriteLine($"str1.Equals(str3) (case-sensitive): {isEqual4}"); // Output: False

        // Using Equals() with StringComparison.OrdinalIgnoreCase (case-insensitive)
        bool isEqual5 = str1.Equals(str3, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine($"str1.Equals(str3, StringComparison.OrdinalIgnoreCase): {isEqual5}"); // Output: True

        // --- Order Comparisons ---
        Console.WriteLine("\n--- Order Comparisons ---");

        string a = "apple";
        string b = "banana";
        string c = "Apple";

        Console.WriteLine($"String a: \"{a}\"");
        Console.WriteLine($"String b: \"{b}\"");
        Console.WriteLine($"String c: \"{c}\"");
        Console.WriteLine();

        // Using CompareTo() (case-sensitive ordinal comparison by default)
        int comparison1 = a.CompareTo(b);
        Console.WriteLine($"a.CompareTo(b): {comparison1} (Negative means a comes before b)"); // Output: Negative

        int comparison2 = b.CompareTo(a);
        Console.WriteLine($"b.CompareTo(a): {comparison2} (Positive means b comes after a)"); // Output: Positive

        int comparison3 = a.CompareTo("apple");
        Console.WriteLine($"a.CompareTo(\"apple\"): {comparison3} (Zero means they are equal)"); // Output: 0

        int comparison4 = a.CompareTo(c);
        Console.WriteLine($"a.CompareTo(c) (case-sensitive): {comparison4} (Lowercase 'a' comes after uppercase 'A' in ordinal)"); // Output: Positive

        // Using CompareTo() with StringComparison.OrdinalIgnoreCase (case-insensitive)
        if (string.CompareOrdinal(a, c) > 0)
        {
            Console.WriteLine($"{a} comes after {c} (ordinal)");
        }


        // Demonstrating the unsupported relational operators for order comparison
        // The following lines will compile, but they compare object references,
        // which is usually not the intended behavior for string ordering.
        // It's important NOT to rely on these for lexicographical comparison.
    }
}

