namespace LiteralsPunctuatorsOperatorsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Literals: Represent constant values.

        // Integer literals
        int age = 30;

        // Decimal literal
        int hexValue = 0x1E;

        // Hexadecimal literal (30 in decimal)
        int binaryValue = 0b11110;

        // Binary literal (30 in decimal)
        // Long literal (L suffix)
        long bigNumber = 1234567890123L;
        
        
        // Floating-point literals
        float price = 99.99f; 

        // Float literal (f suffix)
        double pi = 3.14159;

        // Double literal
        // Scientific notation
        double scientificNotation = 1.23e6;

        // Character literals
        // Single character
        char initial = 'J';

        // Escape sequence (newline)
        char newLine = '\n';

        // Unicode character (A)
        char unicodeChar = '\u0041';

        // String literals
        // String of characters
        string name = "John Doe";

        // Verbatim string literal
        string multiLine = @"This is a multi-line string.";

        // Boolean literals
        // True or false
        bool isAdult = true;    
        bool isStudent = false;


        // Punctuators: Symbols that have syntactic meaning.

        // Parentheses ()
        // Used for grouping expressions
        int result = (10 + 5) * 2;

        // Braces {}
        // Used for code blocks
        if (age >= 18)
        {        
            Console.WriteLine("Adult");
        }

        // Brackets []
        // Used for arrays
        int[] numbers = { 1, 2, 3 };
        // Accessing array element
        Console.WriteLine(numbers[0]);

        // Semicolon ;
        // Statement terminator
        int x = 10;

        // Comma ,// Separating variables
        int a = 1, b = 2, c = 3;

        // Dot . // Accessing members of an object
        string message = "Hello".ToUpper();


        // Operators: Symbols that perform operations on operands.

        // Arithmetic operators
        // Addition
        int sum = age + 10;

        // Subtraction
        int difference = age - 5;

        // Multiplication
        int product = age * 2;

        // Division
        int quotient = age / 3;

        // Modulus (remainder)
        int remainder = age % 3;

        // Assignment operators

        // Assignment
        int y = 20;

        // Addition assignment (y = y + 5)
        y += 5;

        // Subtraction assignment
        y -= 2;

        // Multiplication assignment
        y *= 3;

        // Division assignment
        y /= 2;

        // Comparison operators
        // Equal to
        bool isEqual = (age == 30);

        // Not equal to
        bool isNotEqual = (age != 25);

        // Greater than
        bool isGreater = (age > 20);

        // Less than
        bool isLess = (age < 40);

        // Greater than or equal to
        bool isGreaterOrEqual = (age >= 30);

        // Less than or equal to
        bool isLessOrEqual = (age <= 30);

        // Logical operators
        // Logical AND
        bool andCondition = (age > 18) && (isStudent == false);

        // Logical OR
        bool orCondition = (age < 18) || (isStudent == true);

        // Logical NOT
        bool notCondition = !isStudent; 


        // Outputting some values to demonstrate
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Is Adult: {isAdult}");
        Console.WriteLine($"And Condition: {andCondition}");
    }
}
