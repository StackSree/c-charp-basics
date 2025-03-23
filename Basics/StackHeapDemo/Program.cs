namespace StackHeapDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Stack vs Heap Demonstration ---");
        ValueTypeExample();
        ReferenceTypeExample();
        StackAllocationExample();
        HeapAllocationExample();
    }
    class Person
    {
        public string Name;
        public int Age;
    }

    static void ValueTypeExample()
    {
        int a = 10;
        int b = a; // Copy of 'a' is created in Stack
        b = 20;
        Console.WriteLine($"Value Type Example: a = {a}, b = {b}"); // a remains 10
    }

    static void ReferenceTypeExample()
    {
        Person person1 = new Person { Name = "Alice", Age = 25 };
        Person person2 = person1; // person2 points to the same object in Heap
        person2.Age = 30;
        Console.WriteLine($"Reference Type Example: person1 Age = {person1.Age}, person2 Age = {person2.Age}"); // Both are 30
    }

    static void StackAllocationExample()
    {
        int x = 5;
        int y = 10;
        Console.WriteLine($"Stack Allocation Example: x = {x}, y = {y}");
    }

    static void HeapAllocationExample()
    {
        Person p1 = new Person { Name = "Bob", Age = 40 };
        Console.WriteLine($"Heap Allocation Example: {p1.Name}, Age = {p1.Age}");
    }
}      
