namespace NumericTypesDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Integral Types
        sbyte signedByte = -127;
        byte unsignedByte = 255;
        short signedShort = -32768;
        ushort unsignedShort = 65535;
        int signedInt = -2147483648;
        uint unsignedInt = 4294967295;
        long signedLong = -9223372036854775808;
        ulong unsignedLong = 18446744073709551615;
        nint nativeInt = (nint)(IntPtr.Size == 4 ? -2147483648 : -9223372036854775808); // Example for nint
        nuint nativeUInt = (nuint)(UIntPtr.Size == 4 ? 4294967295 : 18446744073709551615); // Example for nuint

        Console.WriteLine($"sbyte: {signedByte}, byte: {unsignedByte}");
        Console.WriteLine($"short: {signedShort}, ushort: {unsignedShort}");
        Console.WriteLine($"int: {signedInt}, uint: {unsignedInt}");
        Console.WriteLine($"long: {signedLong}, ulong: {unsignedLong}");
        Console.WriteLine($"nint: {nativeInt}, nuint: {nativeUInt}");

        // Floating-Point Types
        float singlePrecisionFloat = 3.14159f; // 'f' suffix is required for float literals
        double doublePrecisionFloat = 3.141592653589793;
        decimal decimalType = 1234567890.1234567890m; // 'm' suffix is required for decimal literals

        Console.WriteLine($"float: {singlePrecisionFloat}");
        Console.WriteLine($"double: {doublePrecisionFloat}");
        Console.WriteLine($"decimal: {decimalType}");

        // Demonstrating range and overflow
        byte smallByte = 250;
        smallByte += 10;
        Console.WriteLine($"byte overflow: {smallByte}"); // Will wrap around to 4, demonstrating overflow.

        int bigInt = 2147483647;
        bigInt++;
        Console.WriteLine($"int overflow: {bigInt}"); // Will wrap around to -2147483648.

        //Demonstrating decimal precision.
        decimal decimal1 = 1.0m;
        decimal decimal2 = 3.0m;
        decimal resultDecimal = decimal1 / decimal2;
        Console.WriteLine($"decimal result: {resultDecimal}");

        double double1 = 1.0;
        double double2 = 3.0;
        double resultDouble = double1 / double2;
        Console.WriteLine($"double result: {resultDouble}");
    }
}