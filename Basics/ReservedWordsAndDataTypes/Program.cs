namespace ReservedWordsAndDataTypes;

internal class Program
{
    static void Main(string[] args)
    {

        // Get all reserved words (keywords) using reflection -  a bit tricky as there's no direct way.
        // We'll try to get them by parsing the language specification (which is not a perfect solution).
        // This is a simplified approach and may not be completely exhaustive.
        string[] reservedWords = GetReservedWords();

        Console.WriteLine("C# Reserved Words:");
        foreach (string word in reservedWords)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("\nC# Data Types:");

        // Get built-in data types using reflection
        Type[] dataTypes = GetBuiltInDataTypes();

        foreach (Type dataType in dataTypes)
        {
            Console.WriteLine(dataType.Name);
        }


        // Common .NET types which are frequently used as if they were built-in
        string[] commonNetTypes = { "string", "object", "dynamic" }; // Add more as needed.
        Console.WriteLine("\nCommon .NET Types (Often Used as Built-in):");
        foreach (string type in commonNetTypes)
        {
            Console.WriteLine(type);
        }

    }


    static string[] GetReservedWords()
    {
        // This is a simplified approach.  A truly comprehensive list would require parsing the C# language specification.
        // It's not a perfect method, but it covers most common reserved words.
        string[] potentialKeywords =  { // Add more as needed.
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
            "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum",
            "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto",
            "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new",
            "null", "object", "operator", "out", "override", "params", "private", "protected", "public",
            "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string",
            "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe",
            "ushort", "using", "virtual", "void", "volatile", "while"
        };

        // You could add checks here to see if these are actually keywords in the current C# version if you wanted to be more precise.
        return potentialKeywords;

    }

    static Type[] GetBuiltInDataTypes()
    {
        // Get primitive types (built-in data types)
        return [
            typeof(bool),
            typeof(byte),
            typeof(char),
            typeof(decimal),
            typeof(double),
            typeof(short),
            typeof(int),
            typeof(long),
            typeof(sbyte),
            typeof(float),
            typeof(ushort),
            typeof(uint),
            typeof(ulong),
            typeof(void) // Technically not a data type, but often grouped with them.
        ];

    }
}

