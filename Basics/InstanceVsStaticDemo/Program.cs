namespace InstanceVsStaticDemo;

internal class Program
{
    /*
     *  In the absence of top-level statements, C# looks for a static method called Main,
        which becomes the entry point. The Main method can be defined inside any class
        The Main method can optionally return an integer (rather than void) in order
        to return a value to the execution environment (where a nonzero value typically
        indicates an error). The Main method can also optionally accept an array of strings
        as a parameter (that will be populated with any arguments passed to the executable).
        For example:
        static int Main (string[] args) {...}
        The Main method can also be declared async and return a Task or Task<int> in
        support of asynchronous programming
     */
    static void Main(string[] args)
    {
        // Creating instances of MyClass
        MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass();

        // Setting instance values
        obj1.instanceValue = 10;
        obj2.instanceValue = 20;

        // Setting static value
        MyClass.staticValue = 100;

        // Calling instance methods
        Console.WriteLine("obj1:");
        // Output: InstanceValue: 10, StaticValue: 100
        obj1.InstanceMethod(); 
        Console.WriteLine("obj2:");
        // Output: InstanceValue: 20, StaticValue: 100
        obj2.InstanceMethod();

        // Calling static method
        Console.WriteLine("Static Method:");
        // Output: StaticValue: 100
        MyClass.StaticMethod(); 

        // Changing static value
        MyClass.staticValue = 200;

        // Calling instance methods again to show the change
        Console.WriteLine("obj1 after static change:");
        // Output: InstanceValue: 10, StaticValue: 200
        obj1.InstanceMethod(); 
        Console.WriteLine("obj2 after static change:");
        // Output: InstanceValue: 20, StaticValue: 200
        obj2.InstanceMethod(); 

        //Demonstrate static vs instance variable behavior.
        MyClass obj3 = new MyClass();
        obj3.instanceValue = 30;
        Console.WriteLine("obj3 before static change");
        obj3.InstanceMethod();

        MyClass.staticValue = 300;

        Console.WriteLine("obj3 after static change");
        obj3.InstanceMethod();
    }
}


/*
 * The public keyword exposes members to other classes.
 */
public class MyClass
{
    // Instance member (field)
    public int instanceValue;

    // Static member (field)
    public static int staticValue;

    // Instance member (method)
    public void InstanceMethod()
    {
        Console.WriteLine($"InstanceValue: {instanceValue}, StaticValue: {staticValue}");
    }

    // Static member (method)
    public static void StaticMethod()
    {
        Console.WriteLine($"StaticValue: {staticValue}");
    }
}
