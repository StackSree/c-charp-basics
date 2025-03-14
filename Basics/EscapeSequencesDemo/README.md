# C# Escape Sequence Demo

This C# program demonstrates the usage of various escape sequence characters.

## Code

```csharp
using System;

public class EscapeSequencesDemo
{
    public static void Main(string[] args)
    {
        // Basic escape sequences
        Console.WriteLine("This is a line with a\nnew line."); // \n - New line
        Console.WriteLine("This is a line with a\ttab.");     // \t - Horizontal tab
        Console.WriteLine("This is a line with a\\backslash."); // \\ - Backslash
        Console.WriteLine("This is a line with a\"double quote\"."); // \" - Double quote
        Console.WriteLine("This is a line with a\'single quote\'."); // \' - Single quote
        Console.WriteLine("This is a line with a\r carriage return."); // \r - Carriage return

        // Unicode escape sequences
        Console.WriteLine("\u0048\u0065\u006C\u006C\u006F"); // Hello (Unicode)
        Console.WriteLine("\u03A9"); // Omega symbol (Unicode)

        // Verbatim string literals (no escape sequences processed)
        string verbatimString = @"This string has \n new lines and \t tabs, but they are not processed.";
        Console.WriteLine(verbatimString);

        // String interpolation with escape sequences
        string name = "Alice";
        int age = 30;
        Console.WriteLine(<span class="math-inline">"Name\: \{name\}\\nAge\: \{age\}"\); // \\n inside interpolated string works\.
        // Hexadecimal escape sequences
        Console.WriteLine\("\\x48\\x65\\x6C\\x6C\\x6F"\); // Hello \(Hexadecimal\)
        //Alert \(bell\)
        Console.WriteLine\("Alert\! \\a"\);
        // Backspace
        Console.WriteLine\("Backspace Example\\b"\);
        //Form feed
        Console.WriteLine\("Form Feed Example\\fNext Page"\);
        //Example of using multiple escape sequences in one string
        string combined \= "This string has a new line\\n, a tab\\t, and a double quote \\"\.";
        Console.WriteLine\(combined\);
        //Example showing the difference between \\r and \\n\.
        Console.WriteLine\("Hello\\rWorld"\); // World replaces hello
        Console.WriteLine\("Hello\\nWorld"\); // Hello on one line, world on the next\.
        // Example with escape sequences in characters\.
        char newLineChar \= '\\n';
        char tabChar \= '\\t';
        Console.WriteLine\(</span>"Newline character: '{newLineChar}', Tab character: '{tabChar}'");

        //Example of using a verbatim string to represent a file path.
        string filePath = @"C:\MyFolder\MyFile.txt";
        Console.WriteLine($"File Path: {filePath}");

        //Example of a unicode character that can cause issues in some fonts.
        Console.WriteLine("\uD83D\uDE00"); //Smiley face, may not render properly in all consoles.
    }
}

## Output
This is a line with a
new line.
This is a line with a      tab.
This is a line with a\backslash.
This is a line with a"double quote".
This is a line with a'single quote'.
This is a line with a
 carriage return.
Hello
Ω
This string has \n new lines and \t tabs, but they are not processed.
Name: Alice
Age: 30
Hello
Alert! 
Backspace Example
Backspace Example
Form Feed Example
Next Page
This string has a new line
, a tab   , and a double quote ".
World
Hello
World
Newline character: '
', Tab character: '        '
File Path: C:\MyFolder\MyFile.txt

## Explanation
This program demonstrates the following escape sequences:

\n: Newline
\t: Horizontal tab
\\: Backslash
\": Double quote
\': Single quote
\r: Carriage return
\uXXXX: Unicode character (where XXXX is the Unicode code point)
\xXX: Hexadecimal character (where XX is the hexadecimal code)
\a: Alert (bell)
\b: Backspace
\f: Form feed
@: Verbatim string literal (disables escape sequence processing)
$: String interpolation
Character literals with escape sequences.
It also shows the difference between \r and \n, the use of verbatim strings for file paths, and potential issues with Unicode character rendering in different consoles.