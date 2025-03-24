using static System.Net.Mime.MediaTypeNames;

namespace DefiniteAssignmentRuleDemo;

internal class Program
{
    // Static field: automatically initialized to 0.
    public static int X;

    // Instance field: automatically initialized to 0.
    public int InstanceField;

    static void Main(string[] args)
    {
        // 1. Local variable: must be assigned before use.
        // The following two lines would result in a compile-time error because 'localVar'
        // is used without initialization.
        // int localVar;
        // Console.WriteLine("Local variable: " + localVar); // Error: use of unassigned local variable

        // Correctly initialize the local variable.
        int localVar = 5;
        Console.WriteLine("Local variable value: " + localVar);  // Outputs: 5

        // 2. Array elements: automatically initialized to default values.
        int[] ints = new int[3];
        Console.WriteLine("First element in the array: " + ints[0]); // Outputs: 0

        // 3. Fields: automatically initialized to default values.
        // Static field 'X' is initialized to 0.
        Console.WriteLine("Static field X: " + Program.X); // Outputs: 0

        // Instance field 'InstanceField' is also initialized to 0.
        Program t = new Program();
        Console.WriteLine("Instance field value: " + t.InstanceField); // Outputs: 0
    }
}
