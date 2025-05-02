namespace UnsafeDemo;

internal class Program
{
    public static unsafe void Main(string[] args)
    {
        int number = 10;

        // Declare a pointer to an int
        int* pointerToNumber = &number;

        Console.WriteLine($"Value of 'number': {number}");
        Console.WriteLine($"Address of 'number': {(long)pointerToNumber:X}"); // Display memory address in hexadecimal

        // Access and modify the value using the pointer
        Console.WriteLine($"Value pointed to by 'pointerToNumber': {*pointerToNumber}");
        *pointerToNumber = 25;
        Console.WriteLine($"Value of 'number' after modification via pointer: {number}");
        Console.WriteLine($"Value pointed to by 'pointerToNumber': {*pointerToNumber}");

        Console.WriteLine("\n--- Working with Arrays ---");
        int[] array = { 1, 2, 3, 4, 5 };

        // Get a pointer to the first element of the array
        fixed (int* pointerToArray = array)
        {
            Console.WriteLine("Array elements via pointer:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element {i}: *(pointerToArray + {i}) = *(pointerToArray + {i})");
            }

            // Modify an element using pointer arithmetic
            *(pointerToArray + 2) = 100;
            Console.WriteLine("\nArray after modification:");
            foreach (int element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        } // The 'fixed' block ensures the array doesn't move in memory while the pointer is in use
    }
}
