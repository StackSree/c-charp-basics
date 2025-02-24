namespace BitManipulationDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Output: 4
        Console.WriteLine("BitCount(29): " + BitCount(29));

        // Output: 1
        Console.WriteLine("GetBit(29, 3): " + GetBit(29, 3));

        // Output: 31
        Console.WriteLine("SetBit(29, 1): " + SetBit(29, 1));

        // Output: 21
        Console.WriteLine("ClearBit(29, 3): " + ClearBit(29, 3));

        // Output: 25
        Console.WriteLine("ToggleBit(29, 2): " + ToggleBit(29, 2));

        // Output: True
        Console.WriteLine("IsPowerOfTwo(16): " + IsPowerOfTwo(16));


        // Output: x = 7, y = 5
        int x = 5, y = 7;
        Swap(ref x, ref y);
        Console.WriteLine($"Swapped: x = {x}, y = {y}");


        // Output: 2684354560
        Console.WriteLine("ReverseBits(5): " + ReverseBits(5));

        // Output: 4
        int[] arr = { 2, 3, 5, 4, 5, 3, 2 };
        Console.WriteLine("FindUnique: " + FindUnique(arr)); 
    }

    public static int BitCount(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count += number & 1;
            number >>= 1;
        }
        return count;
    }

    public static int GetBit(int number, int position)
    {
        return (number >> position) & 1;
    }

    public static int SetBit(int number, int position)
    {
        return number | (1 << position);
    }

    public static int ClearBit(int number, int position)
    {
        return number & ~(1 << position);
    }

    public static int ToggleBit(int number, int position)
    {
        return number ^ (1 << position);
    }

    public static bool IsPowerOfTwo(int number)
    {
        return (number > 0) && ((number & (number - 1)) == 0);
    }

    public static void Swap(ref int a, ref int b)
    {
        a ^= b;
        b ^= a;
        a ^= b;
    }

    public static int ReverseBits(int number)
    {
        int result = 0;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;
            result |= (number & 1);
            number >>= 1;
        }
        return result;
    }

    public static int FindUnique(int[] arr)
    {
        int unique = 0;
        foreach (int num in arr)
        {
            unique ^= num;
        }
        return unique;
    }
}