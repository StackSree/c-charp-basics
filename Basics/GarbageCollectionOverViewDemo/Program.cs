using System.Diagnostics;

namespace GarbageCollectionOverViewDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Demonstrate value types
        int age = 30; // Value type (int) - stored on the stack
        Console.WriteLine($"Age: {age}");

        // Demonstrate reference types
        MyClass? myObject = new MyClass("Example Object"); // Reference type (MyClass) - stored on the heap
        Console.WriteLine($"Object Name: {myObject.Name}");

        // Create many objects to trigger garbage collection
        // increase or decrese the i value for test i< 10000
        Console.WriteLine("Creating many objects...");
        for (int i = 0; i < 10; i++)
        {
            new MyClass($"Object {i}"); // These objects will eventually be garbage collected
        }

        // Force garbage collection (generally not recommended in production code)
        Console.WriteLine("Forcing garbage collection...");
        GC.Collect();
        GC.WaitForPendingFinalizers(); // Wait for finalizers to complete

        // Get memory usage information
        long memoryBeforeGC = Process.GetCurrentProcess().WorkingSet64;
        Console.WriteLine($"Memory used before GC: {memoryBeforeGC / (1024 * 1024)} MB");


        // Create even more objects after GC to demonstrate memory usage change.
        for (int i = 0; i < 10; i++)
        {
            new MyClass($"Object {i + 10000}"); // These objects will eventually be garbage collected
        }

        long memoryAfterGC = Process.GetCurrentProcess().WorkingSet64;
        Console.WriteLine($"Memory used after GC: {memoryAfterGC / (1024 * 1024)} MB");
        Console.WriteLine($"Memory difference: {(memoryAfterGC - memoryBeforeGC) / (1024 * 1024)} MB");


        // Demonstrate object finalization (if applicable)
        myObject = null; // Make the original object unreachable
        Console.WriteLine("Setting myObject to null...");
        GC.Collect(); // Suggest garbage collection (not guaranteed to happen immediately)
        GC.WaitForPendingFinalizers(); // Important! Wait for finalizers to run.
        Console.WriteLine("Finalizers have run (if any).");


        Console.WriteLine("Program finished.");
        Console.ReadKey();
    }
}

public class MyClass
{
    public string Name { get; set; }

    public MyClass(string name)
    {
        Name = name;
        Console.WriteLine($"MyClass constructor called for {Name}");
    }

    // Finalizer (called when the object is about to be garbage collected)
    ~MyClass()
    {
        Console.WriteLine($"MyClass finalizer called for {Name}");
        // Release any unmanaged resources here (e.g., file handles, network connections)
    }
}
