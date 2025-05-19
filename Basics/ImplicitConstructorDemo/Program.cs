namespace ImplicitConstructorDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Implicit Parameterless Constructor:");

        // This works because WithoutExplicitConstructor has an implicit parameterless constructor.
        WithoutExplicitConstructor obj1 = new WithoutExplicitConstructor();
        obj1.Value = 10;
        Console.WriteLine($"Object 1 Value: {obj1.Value}");

        // This will cause a compile-time error if you uncomment it because WithExplicitConstructor
        // does not have a parameterless constructor.
        // WithExplicitConstructor obj2 = new WithExplicitConstructor();

        // This works because we are calling the defined constructor with a parameter.
        WithExplicitConstructor obj3 = new WithExplicitConstructor(20);
        Console.WriteLine($"Object 3 Value: {obj3.Value}");

        Console.WriteLine();
    }

    public class WithoutExplicitConstructor
    {
        public int Value { get; set; }

        // No explicit constructor defined. The compiler will generate a public parameterless one.
    }

    public class WithExplicitConstructor
    {
        public int Value { get; set; }

        public WithExplicitConstructor(int initialValue)
        {
            Value = initialValue;
        }

        // No implicit parameterless constructor here because we defined one with a parameter.
    }
}
