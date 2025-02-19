using System.Reflection;
using System.Runtime.Loader;
using System.Security.Policy;

namespace AppDomainUsage;

internal class Program
{
    static void Main(string[] args)
    {

        string assemblyPath = """C:\Git-Sree\c-charp-basics\Basics\Binding\bin\Debug\net8.0\Binding.dll""";

        // Create a custom load context
        var context = new MyLoadContext();

        // Load assembly into custom context
        Assembly assembly = context.LoadFromAssemblyPath(assemblyPath);

        Console.WriteLine($"Loaded Assembly: {assembly.FullName}");

        var type = assembly.GetType("Binding.Dog");
        var method = type?.GetMethod("Speak");
        var instance = Activator.CreateInstance(type!);
        method?.Invoke(instance, null);

        // Unload the context (when collectible is true)
        context.Unload();
        Console.WriteLine("Assembly Unloaded.");
    }
}

public class MyLoadContext : AssemblyLoadContext
{
    public MyLoadContext() : base(isCollectible: true) { }

    protected override Assembly? Load(AssemblyName assemblyName)
    {
        return null; // Custom logic for loading assemblies if needed
    }
}
