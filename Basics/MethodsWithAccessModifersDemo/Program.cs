namespace MethodsWithAccessModifersDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Accessing members from Main ---");
        MyBaseClass baseObj = new MyBaseClass();
        Console.WriteLine($"Main can access Public: {baseObj.PublicField}");
        Console.WriteLine($"Main can access Internal: {baseObj.InternalField}");
        // Console.WriteLine($"Main cannot directly access Private: {baseObj.PrivateField}"); // Error
        // Console.WriteLine($"Main cannot directly access Protected: {baseObj.ProtectedField}"); // Error
        baseObj.PublicMethod();
        baseObj.InternalMethod();
        // baseObj.ProtectedMethod(); // Error
        // baseObj.PrivateMethod();   // Error

        MyDerivedClass derivedObj = new MyDerivedClass();
        derivedObj.AccessBaseMembersFromDerived();

        AnotherClassInSameAssembly anotherObj = new AnotherClassInSameAssembly();
        anotherObj.AccessBaseMembersFromAnother();

        Console.ReadKey(); // To keep the console window open
    }
}

public class MyBaseClass
{
    public string PublicField = "Public Field in Base";
    internal string InternalField = "Internal Field in Base";
    private string PrivateField = "Private Field in Base";
    protected string ProtectedField = "Protected Field in Base";

    public void PublicMethod()
    {
        Console.WriteLine("Public method in Base accessed.");
        AccessAllFields();
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal method in Base accessed.");
        AccessAllFields();
    }

    private void PrivateMethod()
    {
        Console.WriteLine("Private method in Base accessed.");
        AccessAllFields();
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method in Base accessed.");
        AccessAllFields();
    }

    private void AccessAllFields()
    {
        Console.WriteLine($"  Inside Base: Public={PublicField}, Internal={InternalField}, Private={PrivateField}, Protected={ProtectedField}");
    }
}

public class MyDerivedClass : MyBaseClass
{
    public void AccessBaseMembersFromDerived()
    {
        Console.WriteLine("\n--- Accessing Base members from Derived ---");
        Console.WriteLine($"Derived can access Public: {PublicField}");
        Console.WriteLine($"Derived can access Internal: {InternalField}"); // Accessible in the same assembly
        // Console.WriteLine($"Derived cannot directly access Private: {PrivateField}"); // This would be an error
        Console.WriteLine($"Derived can access Protected: {ProtectedField}");
        ProtectedMethod(); // Can call protected method
        PublicMethod();
        InternalMethod();
    }
}

public class AnotherClassInSameAssembly
{
    public void AccessBaseMembersFromAnother()
    {
        Console.WriteLine("\n--- Accessing Base members from Another Class in Same Assembly ---");
        MyBaseClass baseObj = new MyBaseClass();
        Console.WriteLine($"Another can access Public: {baseObj.PublicField}");
        Console.WriteLine($"Another can access Internal: {baseObj.InternalField}");
        // Console.WriteLine($"Another cannot directly access Private: {baseObj.PrivateField}"); // Error
        // Console.WriteLine($"Another cannot directly access Protected: {baseObj.ProtectedField}"); // Error
        baseObj.PublicMethod();
        baseObj.InternalMethod();
        // baseObj.ProtectedMethod(); // Error
        // baseObj.PrivateMethod();   // Error
    }
}
