namespace DefaultValuesExample;

internal class Program
{
    static void Main(string[] args)
    {
        // Default values for predefined types
        Console.WriteLine("Default values for predefined types:");

        // Reference types
        string referenceType = default(string);
        Console.WriteLine($"string: {referenceType ?? "null"}");

        // Nullable value types
        int? nullableValueType = default(int?);
        Console.WriteLine($"int?: {nullableValueType}");

        // Numeric types
        int intType = default(int);
        Console.WriteLine($"int: {intType}");

        double doubleType = default(double);
        Console.WriteLine($"double: {doubleType}");

        decimal decimalType = default(decimal);
        Console.WriteLine($"decimal: {decimalType}");

        // char type
        char charType = default(char);
        Console.WriteLine($"char: '{charType}'");

        // bool type
        bool boolType = default(bool);
        Console.WriteLine($"bool: {boolType}");

        // Using default keyword without specifying type
        decimal d = default;
        Console.WriteLine($"decimal inferred: {d}");

        // Default value for custom value type (struct)
        Console.WriteLine("\nDefault value for custom value type (struct):");

        MyStruct myStruct = default(MyStruct);
        Console.WriteLine($"MyStruct.intField: {myStruct.intField}");
        Console.WriteLine($"MyStruct.stringField: {myStruct.stringField ?? "null"}");
        Console.WriteLine($"MyStruct.boolField: {myStruct.boolField}");

        MyEnum enumType = default(MyEnum);
        Console.WriteLine($"MyEnum: {enumType}");

    }
}

struct MyStruct
{
    public int intField;
    public string stringField;
    public bool boolField;
}

// Enum types
enum MyEnum { Value1, Value2 }


