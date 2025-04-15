namespace UsingStaticDemo;

using System;
using static System.Console; // Import static members of System.Console
using static System.Math;    // Import static members of System.Math


    public enum Status
    {
        Pending,
        Processing,
        Completed
    }

    public static class MyMathHelper
    {
        public static double CircleArea(double radius)
        {
            return PI * Pow(radius, 2); // Using static members PI and Pow directly
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Example
    {
        public static string Greeting = "Hello from Example!";

        public static void PrintGreeting()
        {
            WriteLine(Greeting); // Using static member WriteLine directly
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Demonstrating 'using static' in C#:");
            WriteLine("------------------------------------");

            // Using static members from System.Console directly
            WriteLine("Using static System.Console:");
            WriteLine("This text is printed using WriteLine without 'Console.' prefix.");
            WriteLine($"Current date: {DateTime.Now.ToShortDateString()}"); // Still need to qualify non-static members

            WriteLine("\nUsing static System.Math:");
            double radius = 5;
            WriteLine($"Area of a circle with radius {radius}: {MyMathHelper.CircleArea(radius):F2}"); // Using static PI and Pow directly

            WriteLine("\nUsing static members from a custom class:");
            Example.PrintGreeting(); // Calling static method
            WriteLine($"Static field from Example: {Example.Greeting}"); // Accessing static field

            WriteLine("\nUsing static members from a custom helper class:");
            int sum = MyMathHelper.Add(10, 5);
            WriteLine($"Sum of 10 and 5: {sum}");

            // Demonstrating ambiguity (comment out to run successfully)
            // using static AmbiguousNamespace1.Calculator;
            // using static AmbiguousNamespace2.Calculator;
            // WriteLine(Multiply(2, 3)); // This would cause a compile-time error due to ambiguity

            WriteLine("\nUsing static with enums (hypothetical - no direct import of enum members in this example):");
            // While you can't directly "using static" on the enum *type* to use member names unqualified
            // in the same way as classes, the text you provided in the prompt is slightly misleading.
            // You still need to qualify enum members with the enum type.
            // However, if you had static members *within* the enum (which is less common), you could import those.
            // The prompt's example about Visibility is more about language design for XAML.
            WriteLine("For enums, you typically still use the enum type (e.g., Status.Pending).");
            WriteLine($"Current status: {Status.Processing}");

            ReadKey(); // To keep the console window open
        }
    }

    // Example namespaces and class to demonstrate ambiguity (commented out by default)
    /*
    namespace AmbiguousNamespace1
    {
        public class Calculator
        {
            public static int Multiply(int a, int b)
            {
                return a * b;
            }
        }
    }

    namespace AmbiguousNamespace2
    {
        public class Calculator
        {
            public static int Multiply(int x, int y)
            {
                return x * y * 2;
            }
        }
    }
    */

