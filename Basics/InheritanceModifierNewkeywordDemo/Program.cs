namespace InheritanceModifierNewkeywordDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Dog dog = new Dog();
        Animal animalAsDog = new Dog();

        Console.WriteLine("--- Calling MakeSound() ---");
        animal.MakeSound();       // Output: Generic animal sound.
        dog.MakeSound();          // Output: Woof! (overridden)
        animalAsDog.MakeSound();  // Output: Woof! (overridden)

        Console.WriteLine("\n--- Calling Eat() ---");
        animal.Eat();           // Output: Animal is eating.
        dog.Eat();              // Output: Dog is eating a bone. (new)
        animalAsDog.Eat();      // Output: Animal is eating. (base class implementation called because Eat() in Animal is not virtual)
    }
}

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Generic animal sound.");
    }

    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    // Uses 'override' to replace the base class's virtual method
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    // Uses 'new' to explicitly hide the base class's non-virtual method
    public new void Eat()
    {
        Console.WriteLine("Dog is eating a bone.");
    }
}
