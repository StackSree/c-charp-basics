namespace AccessModifiersDemo;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Accessing members from within the same assembly ---");

        PublicClass publicObj = new PublicClass();
        Console.WriteLine("Accessing public field of PublicClass: " + publicObj.PublicField);
        publicObj.PublicMethod();
        publicObj.AccessProtectedPrivate();
        Console.WriteLine("Accessing protected internal field of PublicClass: " + publicObj.ProtectedInternalField);
        publicObj.ProtectedInternalMethod();

        Console.WriteLine("\n--- Accessing internal members from within the same assembly ---");
        InternalClass internalObj = new InternalClass();
        Console.WriteLine("Accessing internal field of InternalClass: " + internalObj.InternalField);
        internalObj.InternalMethod();
        Console.WriteLine("Accessing protected internal field of InternalClass: " + internalObj.ProtectedInternalField);
        internalObj.ProtectedInternalMethod();
        internalObj.AccessInternalPrivate();

        Console.WriteLine("\n--- Accessing from another public class in the same assembly ---");
        AnotherPublicClass anotherObj = new AnotherPublicClass();
        anotherObj.AccessPublicInternal();

        Console.WriteLine("\n--- Demonstrating protected access via inheritance ---");
        DerivedFromPublic derivedObj = new DerivedFromPublic();
        derivedObj.AccessBaseProtected();
    }
}

public class InternalClass
{
    internal string InternalField = "I am internal!";

    internal void InternalMethod()
    {
        Console.WriteLine("InternalClass.InternalMethod: " + InternalField);
    }

    // Private member - accessible only within InternalClass
    private string privateInternalField = "I am private to InternalClass";

    private void PrivateInternalMethod()
    {
        Console.WriteLine("InternalClass.PrivateInternalMethod: " + privateInternalField);
    }

    // Protected internal member - accessible within this assembly and derived classes (even in other assemblies)
    protected internal string ProtectedInternalField = "I am protected internal!";

    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("InternalClass.ProtectedInternalMethod: " + ProtectedInternalField);
        PrivateInternalMethod(); // Can access private members of the same class
    }

    public void AccessInternalPrivate()
    {
        Console.WriteLine("InternalClass.AccessInternalPrivate: " + privateInternalField); // Public method accessing private member
        PrivateInternalMethod();
    }
}

// Public class - accessible from anywhere
public class PublicClass : InternalClass // Inherits from InternalClass
{
    public string PublicField = "I am public!";

    public void PublicMethod()
    {
        Console.WriteLine("PublicClass.PublicMethod: " + PublicField);
        InternalMethod(); // Can access internal members because it's in the same assembly
        Console.WriteLine("PublicClass.PublicMethod accessing protected internal: " + ProtectedInternalField);
        ProtectedInternalMethod();
    }

    // Protected member - accessible within PublicClass and derived classes
    protected string ProtectedField = "I am protected!";

    protected void ProtectedMethod()
    {
        Console.WriteLine("PublicClass.ProtectedMethod: " + ProtectedField);
    }

    // Private member - accessible only within PublicClass
    private string PrivateField = "I am private!";

    private void PrivateMethod()
    {
        Console.WriteLine("PublicClass.PrivateMethod: " + PrivateField);
    }

    public void AccessProtectedPrivate()
    {
        Console.WriteLine("PublicClass.AccessProtectedPrivate accessing protected: " + ProtectedField);
        ProtectedMethod();
        Console.WriteLine("PublicClass.AccessProtectedPrivate accessing private: " + PrivateField);
        PrivateMethod();
    }
}

// Another public class in the same assembly
public class AnotherPublicClass
{
    public void AccessPublicInternal()
    {
        PublicClass publicObj = new PublicClass();
        Console.WriteLine("AnotherPublicClass accessing public field: " + publicObj.PublicField);
        publicObj.PublicMethod();

        InternalClass internalObj = new InternalClass();
        Console.WriteLine("AnotherPublicClass accessing internal field: " + internalObj.InternalField);
        internalObj.InternalMethod();
        Console.WriteLine("AnotherPublicClass accessing protected internal field: " + internalObj.ProtectedInternalField);
        internalObj.ProtectedInternalMethod();
        internalObj.AccessInternalPrivate();
    }
}

// Public class derived from PublicClass
public class DerivedFromPublic : PublicClass
{
    public void AccessBaseProtected()
    {
        Console.WriteLine("DerivedFromPublic accessing protected field: " + ProtectedField);
        ProtectedMethod();
        Console.WriteLine("DerivedFromPublic accessing protected internal field: " + ProtectedInternalField);
        ProtectedInternalMethod();
        // Cannot access private members of the base class directly
        // Console.WriteLine(PrivateField); // Compilation error
        // PrivateMethod(); // Compilation error
    }
}
