namespace UnsafeClassDemo;

internal class Program
{
    static unsafe void Main(string[] args)
    {
        UnsafeDemo obj = new UnsafeDemo(5);
        Console.WriteLine($"Original value: {obj.Value}");

        obj.SquareValue();
        Console.WriteLine($"Squared value (via unsafe method): {obj.Value}");

        int number = 10;
        int* numPtr = &number; // Get a pointer to a local variable

        Console.WriteLine($"Original number: {number}");
        *numPtr *= 3; // Modify the value through the pointer
        Console.WriteLine($"Modified number (via unsafe block): {number}");
    }
}
unsafe class UnsafeDemo
{
    public int Value;

    public UnsafeDemo(int val)
    {
        Value = val;
    }

    public unsafe void SquareValue()
    {
        fixed (int* ptr = &Value)
        {
            *ptr *= *ptr;
        }     // Dereference the pointer and square the value
    }
}
