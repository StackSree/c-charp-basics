namespace StringDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Regular string with escape sequences
        string regularString = "This is a regular string.\nIt has a tab:\tAnd a backslash: \\";
        Console.WriteLine("Regular String:");
        Console.WriteLine(regularString);

        // Verbatim string
        string verbatimString = @"This is a verbatim string.
                                It can span multiple lines.
                                It doesn't process escape sequences.
                                A double quote is written like this: """;
        Console.WriteLine("\nVerbatim String:");
        Console.WriteLine(verbatimString);

        // String equality
        string str1 = "Hello";
        string str2 = "Hello";
        string str3 = "World";

        Console.WriteLine("\nString Equality:");
        Console.WriteLine($"str1 == str2: {str1 == str2}"); // True
        Console.WriteLine($"str1 == str3: {str1 == str3}"); // False

        // String interpolation
        string name = "Bob";
        int age = 30;
        string interpolatedString = $"My name is {name} and I am {age} years old.";
        Console.WriteLine("\nInterpolated String:");
        Console.WriteLine(interpolatedString);

        // String immutability demo
        string originalString = "Original";
        string modifiedString = originalString.ToUpper(); // creates a new string
        Console.WriteLine("\nString Immutability:");
        Console.WriteLine($"Original string: {originalString}"); // Original
        Console.WriteLine($"Modified string: {modifiedString}"); // ORIGINAL

        //String Builder Demo
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("This is a ");
        sb.Append("StringBuilder ");
        sb.Append("demo.");
        string finalString = sb.ToString();
        Console.WriteLine("\nStringBuilder Demo:");
        Console.WriteLine(finalString);

        //Path example
        string path = @"C:\MyFolder\MyFile.txt";
        Console.WriteLine("\nPath example:");
        Console.WriteLine(path);

        //Unicode Example
        string unicodeString = "こんにちは";
        Console.WriteLine("\nUnicode Example:");
        Console.WriteLine(unicodeString);
    }
}
