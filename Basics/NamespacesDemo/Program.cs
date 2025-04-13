using UtilitiesNamespacesDemo; // Diffrent namespace
namespace NamespacesDemo; // File-scoped namespace
internal class Program
{
    static void Main(string[] args)
    {
        // Using a class from the current namespace
        var demoClass = new DemoClass();
        demoClass.DoSomething();

        // Using a class from the MyLibrary.Utilities namespace
        var helper = new StringHelper();
        Console.WriteLine(helper.ReverseString("hello"));
    }

    public class DemoClass
    {
        public void DoSomething()
        {
            Console.WriteLine("Doing something in NamespaceDemo.");
        }
    }
}
