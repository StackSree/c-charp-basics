using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplicitGlobalUsingDemo;

internal class Program
{

    /*
     * <ImplicitUsings>enable</ImplicitUsings>
     * The above using statements are not required for the below program.
     * 
     * To demo above, <ImplicitUsings>disable</ImplicitUsings>, check in the csproj file.
     * */
    static void Main(string[] args)
    {
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
        Console.WriteLine($"Number of names: {names.Count}");
        Console.WriteLine($"First name (uppercase): {names.First().ToUpper()}");
        Task.Delay(1000).Wait(); // Using System.Threading.Tasks
        Console.WriteLine("Task completed.");
        Console.WriteLine("Hello, World!");
    }
}
