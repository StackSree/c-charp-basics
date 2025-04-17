namespace AliasAnyTypeDemo;

// 1. Simplifying Complex Type Declarations
using Matrix4x4 = double[,,,];
using IntPtrAlias = IntPtr;
using StringDictionary = Dictionary<string, List<string>>;

// 2. Improving Code Readability
using UserIdentifier = Guid;

// 4. Providing Context (Domain-Specific Language)
using CurrencyAmount = decimal;
using InterestRate = double;

// 6. Aliasing Tuples
using PersonData = (string Name, int Age, string City);

internal class Program
{

    static void Main(string[] args)
    {
        // 1. Simplifying Complex Type Declarations
        Matrix4x4 transformationMatrix = new double[4, 4, 4, 4];
        transformationMatrix[0, 0, 0, 0] = 1.0;

        IntPtrAlias memoryAddress = IntPtr.Zero;

        StringDictionary headers = new StringDictionary
            {
                { "Content-Type", new List<string> { "application/json" } },
                { "Authorization", new List<string> { "Bearer token123" } }
            };

        // 2. Improving Code Readability
        UserIdentifier userId = Guid.NewGuid();
        Console.WriteLine($"User ID: {userId}");

        // 4. Providing Context (Domain-Specific Language)
        CurrencyAmount amount = 1234.56M;
        InterestRate rate = 0.05;
        Console.WriteLine($"Amount: {amount}, Rate: {rate}");

        // 6. Aliasing Tuples
        PersonData person = ("John Doe", 30, "New York");
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, City: {person.City}");
    }
}
