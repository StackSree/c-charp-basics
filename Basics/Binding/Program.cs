using System.Reflection;

namespace Binding;

internal class Program
{
    static void Main(string[] args)
    {
        // Early binding, resolved at compile-time
        Dog dog = new Dog();
        dog.Speak();

        // Also early binding
        Animal animal = new Animal();
        animal.Speak();


        // Late binding using reflection
        Type type = typeof(Animal);

        // Create an instance dynamically
        object obj = Activator.CreateInstance(type);

        // Get method information
        MethodInfo method = type.GetMethod("Speak"); 

        method.Invoke(obj, null); // Invoke method dynamically
    }
}

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

