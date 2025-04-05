namespace BitwiseOperations;

internal class Program
{
    static void Main(string[] args)
    {
        int original = 0b10101010; // 170 in decimal
        int startIdx = 2;
        int endIdx = 5;
        int newVal = 0b011; // 3 in decimal

        int modified = ModifyBits(original, startIdx, endIdx, newVal);
        Console.WriteLine($"Final modified binary: {Convert.ToString(modified, 2)}");
    }

    public static int ModifyBits(int num, int start, int end, int newValue)
    {
        // Convert original number to binary for reference
        Console.WriteLine($"Original binary: {Convert.ToString(num, 2)}");

        // Create a mask for the range of bits to be replaced
        int mask = ((1 << (end - start + 1)) - 1) << start;

        // Extract the bits before modification for validation
        int extractedBits = (num & mask) >> start;
        Console.WriteLine($"Extracted original bits: {Convert.ToString(extractedBits, 2)}");

        // Clear the bits in the given range
        num &= ~mask;

        // Set the new value in the cleared bit range
        num |= (newValue << start) & mask;

        // Convert modified number to binary for comparison
        Console.WriteLine($"Modified binary: {Convert.ToString(num, 2)}");

        // Convert modified number to decimal
        Console.WriteLine($"Modified decimal: {num}");

        // Extract the replaced bits for validation
        int replacedBits = (num & mask) >> start;
        Console.WriteLine($"Replaced bits: {Convert.ToString(replacedBits, 2)}");

        if (replacedBits != (newValue & ((1 << (end - start + 1)) - 1)))
        {
            throw new Exception("Bit replacement verification failed!");
        }

        return num;
    }
}
