namespace SimpleStatmentDemo;

internal class Program
{
    //In C#, a statement block (also called a compound statement) is a group of statements enclosed in curly braces {}.
    //It is often used to group multiple statements where the language syntax requires a single statement—like in if, for, while, etc.
    static void Main(string[] args)
    {
        Console.WriteLine("Demo of a Statement Block in C#");

        // Start of the statement block
        {
            // Declaration statement
            int a = 10;
            int b = 20;

            // Expression statements
            int sum = a + b;
            Console.WriteLine("Sum of a and b: " + sum);

            b *= 2;
            Console.WriteLine("Value of b after doubling: " + b);
        } // End of the block

        Console.WriteLine("Block execution finished.");
    }
}
