namespace InstanceConstructorsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Using the public constructor
        Panda petey = new Panda("Petey");
        petey.Greet();

        Console.WriteLine();

        // Using the internal constructor (accessible within the same assembly)
        Panda oldPanda = new Panda(10);
        oldPanda.Greet();

        Console.WriteLine();

        // Using the expression-bodied constructor
        Panda charPanda = new Panda('C');
        charPanda.Greet();

        Console.WriteLine();

        // Using the constructor with 'this' keyword
        Panda anotherPetey = new Panda("Another Petey");
        anotherPetey.Greet();

        Console.WriteLine();

        // Using the static method to access the private constructor
        Panda friendlyPanda = Panda.CreateFriendlyPanda("Friendly");
        friendlyPanda.Greet();

        // The following line would cause a compilation error because the private
        // constructor is not directly accessible from outside the Panda class.
        // Panda secretPanda = new Panda("Secret", false);
    }

    public class Panda
    {
        string name; // Define field

        // Public instance constructor
        public Panda(string n)
        {
            Console.WriteLine($"Creating a Panda named {n} using the public constructor.");
            name = n; // Initialization code (set up field)
        }

        // Internal instance constructor
        internal Panda(int age)
        {
            Console.WriteLine($"Creating a Panda with age {age} using the internal constructor.");
            name = $"Panda aged {age}";
        }

        // Private instance constructor (can only be called from within the class)
        private Panda(string n, bool isFriendly)
        {
            Console.WriteLine($"Creating a Panda named {n} (friendly: {isFriendly}) using the private constructor.");
            name = n;
        }

        // Expression-bodied constructor
        public Panda(char initial) => name = $"Panda starting with {initial}";

        // Constructor with 'this' keyword to disambiguate
       // public Panda(string name) => this.name = name;

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {name}!");
        }

        // Static method to demonstrate calling the private constructor
        public static Panda CreateFriendlyPanda(string name)
        {
            return new Panda(name, true);
        }
    }
}
