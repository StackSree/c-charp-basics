namespace MethodOverloadDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Method Overloading Demo");

        Foo(5);
        Foo(5.5);
        Foo(5, 3.3f);
        Foo(3.3f, 5);

        int a = 10;
        Foo(ref a);
        Console.WriteLine("After ref Foo: " + a);

        // Uncommenting the line below will cause a compile-time error due to conflict with ref
        // int b;
        // Foo(out b); // ERROR if Foo(ref int) already exists
    }

    // Valid overloads
    static void Foo(int x) => Console.WriteLine("Foo(int)");
    static void Foo(double x) => Console.WriteLine("Foo(double)");
    static void Foo(int x, float y) => Console.WriteLine("Foo(int, float)");
    static void Foo(float x, int y) => Console.WriteLine("Foo(float, int)");

    // ref and out differentiate the signature
    static void Foo(ref int x)
    {
        x += 5;
        Console.WriteLine("Foo(ref int)");
    }

    // Uncommenting this will cause a compile-time error:
    // static void Foo(out int x)
    // {
    //     x = 100;
    //     Console.WriteLine("Foo(out int)");
    // }

    // Invalid overloads – Uncomment to see compile-time errors:

    // float Foo(int x) => 3.14f; // ❌ Return type only is not a valid overload

    // static void Goo(int[] x) => Console.WriteLine("Goo(int[])");
    // static void Goo(params int[] x) => Console.WriteLine("Goo(params int[])"); // ❌ Conflict
}
