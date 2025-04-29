namespace FieldsModifierStaticDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Initial Total Count: {Counter.TotalCount}"); // Accessing static field using the class name

        Counter counter1 = new Counter();
        Console.WriteLine($"Counter 1 Instance Count: {counter1.InstanceCount}, Total Count: {Counter.TotalCount}");

        Counter counter2 = new Counter();
        Console.WriteLine($"Counter 2 Instance Count: {counter2.InstanceCount}, Total Count: {Counter.TotalCount}");

        counter1.IncrementInstanceCount();
        Console.WriteLine($"Counter 1 Instance Count after increment: {counter1.InstanceCount}, Total Count: {Counter.TotalCount}");

        Counter.DisplayTotalCount(); // Accessing the static method using the class name
    }
}

public class Counter
{
    // Static field to keep track of the total count across all Counter objects
    public static int TotalCount;

    // Instance field to keep track of the count for a specific Counter object
    public int InstanceCount;

    public Counter()
    {
        InstanceCount = 0;
        TotalCount++; // Increment the static counter when a new Counter object is created
    }

    public void IncrementInstanceCount()
    {
        InstanceCount++;
    }

    public static void DisplayTotalCount()
    {
        Console.WriteLine($"Total Counter instances created: {TotalCount}");
    }
}
