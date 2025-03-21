namespace ArrayAddressDemo;

internal class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[10]; // Declares an integer array 'a' with 10 elements.

        // In C#, you cannot directly print the memory address of an array in the same way as in C.
        // C# handles memory management differently, and directly exposing raw memory addresses is generally discouraged.
        // However, we can use unsafe code to get a pointer to the first element of the array.

        unsafe
        {
            fixed (int* ptr = a)
            {
                // Convert the pointer to an IntPtr (integer pointer) and then to a string.
                IntPtr address = (IntPtr)ptr;
                Console.WriteLine($"pointer address{address}");
                Console.WriteLine($"address{address.ToString()}");
                // Or you can use the more specific pointer format
                Console.WriteLine($"address in hexdeceimal {(long)ptr:X}"); //prints the address in hex
            }
        }
    }
}
