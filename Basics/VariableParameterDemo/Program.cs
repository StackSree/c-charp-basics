namespace VariableParameterDemo;

internal class Program
{
    static void Main(string[] args)
    {
        VariableDemo demo = new VariableDemo();

        // Local variable demo
        demo.LocalVariableDemo();

        // Parameter demo
        int originalValue = 5;
        int refValue = 15;
        int outValue;
        int inValue = 25;

        demo.ParameterDemo(originalValue, ref refValue, out outValue, in inValue);

        Console.WriteLine($"Original Value (after method): {originalValue}"); // Remains 5
        Console.WriteLine($"Ref Value (after method): {refValue}"); // Becomes 40
        Console.WriteLine($"Out Value (after method): {outValue}"); // Becomes 60

        // Instance and static field demo
        Console.WriteLine($"Instance Field: {demo.instanceField}");
        Console.WriteLine($"Static Field: {VariableDemo.staticField}");

        VariableDemo demo2 = new VariableDemo();
        demo2.instanceField = 999;
        VariableDemo.staticField = 1000;

        Console.WriteLine($"demo Instance Field: {demo.instanceField}"); //50, instances are independent
        Console.WriteLine($"demo2 Instance Field: {demo2.instanceField}"); //999, instances are independent
        Console.WriteLine($"Static Field (both demos): {VariableDemo.staticField}"); //1000, static is shared.

        // Array element demo
        demo.ArrayElementDemo();
    }
}
public class VariableDemo
{
    // Static field (class-level variable)
    public static int staticField = 100;

    // Instance field (object-level variable)
    public int instanceField = 50;

    public void LocalVariableDemo()
    {
        // Local variable (within this method)
        int localVar = 20;
        Console.WriteLine($"Local Variable: {localVar}");
    }

    public void ParameterDemo(int valueParam, ref int refParam, out int outParam, in int inParam)
    {
        // Value parameter (copy of the argument)
        valueParam = 30; // Changes here don't affect the original

        // ref parameter (reference to the original argument)
        refParam = 40; // Changes here DO affect the original

        // out parameter (must be assigned a value)
        outParam = 60;

        // in parameter (read-only reference)
        Console.WriteLine($"In Parameter: {inParam}");
        //inParam = 99; //This would throw an error.

        Console.WriteLine($"Value Parameter (inside method): {valueParam}");
        Console.WriteLine($"Ref Parameter (inside method): {refParam}");
        Console.WriteLine($"Out Parameter (inside method): {outParam}");

    }

    public void ArrayElementDemo()
    {
        // Array element (variable within an array)
        int[] myArray = { 1, 2, 3 };
        myArray[1] = 77; // Modifying an array element
        Console.WriteLine($"Array Element myArray[1]: {myArray[1]}");
    }
}
