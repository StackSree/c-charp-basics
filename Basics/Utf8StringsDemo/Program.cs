using System.Text.Json;
using System.Text;

namespace Utf8StringsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // 1. Basic UTF-8 String Literal
        ReadOnlySpan<byte> utf8Literal = "你好, world!"u8; // Contains non-ASCII characters

        Console.WriteLine("1. Basic UTF-8 Literal:");
        Console.WriteLine($"   Byte Count: {utf8Literal.Length}");
        Console.WriteLine($"   UTF-8 Bytes: {string.Join(" ", utf8Literal.ToArray())}");
        Console.WriteLine($"   Decoded String: {Encoding.UTF8.GetString(utf8Literal)}");
        Console.WriteLine();

        // 2. JSON Example (Simulated)
        string jsonString = @"{ ""name"": ""John Doe"", ""city"": ""東京"" }"; // Contains non-ASCII


        byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonString);
        ReadOnlySpan<byte> jsonUtf8 = new ReadOnlySpan<byte>(jsonBytes);
      
        Console.WriteLine("2. JSON Example (Corrected):");
        Console.WriteLine($"   Original JSON: {jsonString}");
        Console.WriteLine($"   JSON Byte Count: {jsonUtf8.Length}");

        try
        {
            // Use the correct overload of JsonDocument.Parse() that takes ReadOnlySpan<byte>
            JsonDocument doc = JsonDocument.Parse(jsonUtf8.ToArray().AsMemory());
            JsonElement root = doc.RootElement;
            string name = root.GetProperty("name").GetString();
            string city = root.GetProperty("city").GetString();

            Console.WriteLine($"   Parsed Name: {name}");
            Console.WriteLine($"   Parsed City: {city}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"   JSON Parsing Error: {ex.Message}");
        }

        Console.WriteLine();

        // 3. Performance Comparison (Simplified)
        string regularString = "This is a long string with some non-ASCII characters: 🚀🚀🚀";
        byte[] regularUtf8Bytes;
        ReadOnlySpan<byte> utf8LiteralLong = "This is a long string with some non-ASCII characters: 🚀🚀🚀"u8;

        Console.WriteLine("3. Performance Comparison (Simplified):");

        // Convert regular string to UTF-8 bytes
        var startTime = DateTime.Now;
        regularUtf8Bytes = Encoding.UTF8.GetBytes(regularString);
        var endTime = DateTime.Now;
        var regularConversionTime = endTime - startTime;

        Console.WriteLine($"   Regular String Conversion Time: {regularConversionTime.TotalMilliseconds} ms");
        Console.WriteLine($"   UTF-8 Literal Byte Count: {utf8LiteralLong.Length}");
        Console.WriteLine($"   Regular String Byte Count: {regularUtf8Bytes.Length}");

        // Note: This is a simplified performance comparison. For accurate benchmarking, use a proper benchmarking tool.
        // In real-world scenarios, the performance benefits of UTF-8 literals are more significant when dealing with large strings or frequent conversions.
    }
}
