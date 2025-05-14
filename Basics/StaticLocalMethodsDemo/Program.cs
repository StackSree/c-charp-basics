namespace StaticLocalMethodsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Example 1: Non-static local method accessing a local variable
        Console.WriteLine("Example 1: Non-static local method");
        int outerVariable = 10;

        void NonStaticLocalMethod()
        {
            Console.WriteLine($"  Outer variable: {outerVariable}"); // Accesses outerVariable
        }

        NonStaticLocalMethod(); // Call the local method

        // Example 2: Static local method - cannot access local variable
        Console.WriteLine("\nExample 2: Static local method");
        int outerVariable2 = 20;

        static void StaticLocalMethod()
        {
            // Console.WriteLine($"Outer variable: {outerVariable2}"); // CS8425: Cannot access outerVariable2
            Console.WriteLine("  Static local method cannot access outer variables.");
            int localVar = 5;
            Console.WriteLine($"  Local variable inside StaticLocalMethod: {localVar}");
        }

        StaticLocalMethod();

        // Example 3: Top-level statements and local methods
        Console.WriteLine("\nExample 3: Top-level statements and local methods");
        int topLevelVariable = 30;

        void TopLevelLocalMethod()
        {
            Console.WriteLine($"  Top-level variable from TopLevelLocalMethod: {topLevelVariable}"); // Accesses topLevelVariable
        }
        TopLevelLocalMethod();

        static void StaticTopLevelLocalMethod()
        {
            //Console.WriteLine($"  Top-level variable from StaticTopLevelLocalMethod: {topLevelVariable}");  // CS8425: Cannot access topLevelVariable
            Console.WriteLine("  Static local method in top-level statements cannot access top-level variables.");
        }
        StaticTopLevelLocalMethod();

        Console.WriteLine("\nExample 4: Passing parameters to static local method");
        int value1 = 5;
        int value2 = 7;

        static void StaticMethodWithParameters(int param1, int param2)
        {
            Console.WriteLine($"  Parameter 1: {param1}, Parameter 2: {param2}");
        }

        StaticMethodWithParameters(value1, value2); // Pass values from the outer scope

        Console.WriteLine("\nExample 5: Returning values from local methods");

        int result = NonStaticReturningMethod(5, 3);
        Console.WriteLine($"  Result from NonStaticReturningMethod: {result}");

        int staticResult = StaticReturningMethod(10, 2);
        Console.WriteLine($"  Result from StaticReturningMethod: {staticResult}");

        int NonStaticReturningMethod(int a, int b)
        {
            return a + b + outerVariable; // Can access outerVariable in this scope
        }

        static int StaticReturningMethod(int a, int b)
        {
            return a - b; // Cannot access outerVariable
        }
    }
}
