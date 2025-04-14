# Implicit Usings Demo in C#

This project demonstrates the use of **Implicit Usings** in C#/.NET 6 and above. With implicit usings enabled, many commonly used namespaces are automatically included, allowing you to write cleaner and shorter code files.

## 💡 What Are Implicit Usings?

When `<ImplicitUsings>enable</ImplicitUsings>` is specified in the `.csproj` file, the compiler automatically includes a set of common namespaces.
This reduces the need to manually add `using` statements at the top of each file.

Example namespaces that are implicitly included:

- `System`
- `System.Collections.Generic`
- `System.Linq`
- `System.Threading.Tasks`
- And more...

## 📜 Example Code

Here's the core logic of the program:

```csharp
static void Main(string[] args)
{
    List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
    Console.WriteLine($"Number of names: {names.Count}");
    Console.WriteLine($"First name (uppercase): {names.First().ToUpper()}");
    Task.Delay(1000).Wait(); // Using System.Threading.Tasks
    Console.WriteLine("Task completed.");
    Console.WriteLine("Hello, World!");
}
```

Notice how this program uses:

- `List<T>` from `System.Collections.Generic`
- LINQ method `.First()` from `System.Linq`
- `Task.Delay()` from `System.Threading.Tasks`

✅ All of this works **without manually importing** any of those namespaces—thanks to implicit usings.

## 🔧 How to Toggle Implicit Usings

You can control implicit usings via your `.csproj` file:

```xml
<PropertyGroup>
  <ImplicitUsings>enable</ImplicitUsings>  <!-- Enable or disable this line -->
  <Nullable>enable</Nullable>
</PropertyGroup>
```

To see what happens without implicit usings, change it to:

```xml
<ImplicitUsings>disable</ImplicitUsings>
```

Then, try building your code—you’ll need to manually add the required `using` statements.

## ▶️ Running the App

```bash
dotnet run
```

Expected output:

```
Number of names: 3
First name (uppercase): ALICE
Task completed.
Hello, World!
```

## 🧪 Bonus Challenge

Try disabling implicit usings and see which `using` directives are needed to make the code compile again!
