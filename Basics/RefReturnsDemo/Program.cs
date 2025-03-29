namespace RefReturnsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        int[] data = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original array: " + string.Join(", ", data));

        // Get a reference to the third element (index 2)
        ref int thirdElement = ref GetReference(data, 2);

        // Modify the value through the reference
        thirdElement = 100;
        Console.WriteLine("Array after modifying third element via ref return: " + string.Join(", ", data));

        // Get a reference to the first element and modify it
        ref int firstElement = ref GetReference(data, 0);
        firstElement = -5;
        Console.WriteLine("Array after modifying first element via ref return: " + string.Join(", ", data));

        try
        {
            // Attempt to get a reference to an out-of-bounds element
            ref int invalidElement = ref GetReference(data, 10);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static ref int GetReference(int[] array, int index)
    {
        if (index >= 0 && index < array.Length)
        {
            return ref array[index];
        }
        throw new IndexOutOfRangeException();
    }
}

