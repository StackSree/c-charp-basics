namespace AbstractionAndInheritanceDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Creating object of derived class
        Dog myDog = new Dog();

        // Calls overridden method
        myDog.MakeSound();

        // Calls inherited method
        myDog.Eat(); 
    }
}

// Abstract class (Abstraction)
abstract class Animal  
{
    // Abstract method (must be implemented in derived class)
    public abstract void MakeSound();

    // Concrete method (can be inherited)
    public void Eat() 
    {
        Console.WriteLine("This animal eats food.");
    }
}


// Dog class inherits from Animal (Inheritance)
class Dog : Animal
{
    // Implementing the abstract method (Abstraction)
    public override void MakeSound() 
    {
        Console.WriteLine("Dog barks!");
    }
}
