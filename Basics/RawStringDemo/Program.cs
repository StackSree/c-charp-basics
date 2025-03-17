namespace RawStringDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Single-line raw string literal
        string xml = """<element attribute="value">Content</element>""";
        Console.WriteLine("Single-line XML:");
        Console.WriteLine(xml);
        Console.WriteLine();

        // Raw string with embedded triple quotes
        string tripleQuotes = """"This string contains """ triple quotes."""";
        Console.WriteLine("Embedded triple quotes:");
        Console.WriteLine(tripleQuotes);
        Console.WriteLine();

        // Multiline raw string literal with indentation
        string json = """
        {
            "name": "Alice",
            "age": 30,
            "city": "New York"
        }
        """;
        Console.WriteLine("Multiline JSON:");
        Console.WriteLine(json);
        Console.WriteLine();

        // Multiline raw string literal with varying indentation
        string code = """
        public class Example
        {
            public void Method()
            {
                Console.WriteLine("Hello, world!");
            }
        }
        """;
        Console.WriteLine("Multiline code:");
        Console.WriteLine(code);
        Console.WriteLine();

        // Interpolated raw string literal
        string name = "Bob";
        int age = 25;
        string interpolated = $"""My name is {name} and I am {age} years old.""";
        Console.WriteLine("Interpolated raw string:");
        Console.WriteLine(interpolated);
        Console.WriteLine();

        //Interpolated raw string literal with escaped curly braces.
        int number = 5;
        string escapedInterpolation = $"The number is {number}. To escape a curly brace use {{ }}. To display the variable within curly braces use  {number} ";
        Console.WriteLine("Escaped curly braces in interpolated raw string:");
        Console.WriteLine(escapedInterpolation);
        Console.WriteLine();

        //Example of an error.
        // string errorExample = """
        // Line 1
        //  Line 2
        //""";
        //The above example will produce a compile time error, because the second line has less indentation than the closing quotes.

        string correctIndentation = """
            Line 1
            Line 2
            """;
        Console.WriteLine("Correctly indented multiline raw string:");
        Console.WriteLine(correctIndentation);
    }
}