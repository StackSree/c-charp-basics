# Assembly Alias Demo: Using `extern alias` in C#

This simple console application demonstrates the use of the `extern alias` feature in C# to resolve type name collisions when referencing multiple assemblies containing types with the same fully-qualified names.

## Problem Scenario

Imagine you have two different versions of a library (e.g., `GridV1.dll` and `GridV2.dll`), both containing a class named `Grid` within the same namespace (`MyCompany.Controls`). If you try to reference both assemblies directly in your project, the C# compiler will encounter an ambiguity error because it won't know which `MyCompany.Controls.Grid` class you intend to use.

## Solution: `extern alias`

The `extern alias` keyword provides a mechanism to assign unique aliases to the referenced assemblies. This allows you to explicitly specify which assembly's type you want to use by qualifying the type name with the assigned alias.

## Project Structure

The solution consists of three projects:

1.  **`GridV1` (Class Library):**

    - Contains a class `Grid` within the `MyCompany.Controls` namespace.
    - This version has a `Version` property set to "Version 1.0" and a `DisplayVersion()` method.

2.  **`GridV2` (Class Library):**

    - Also contains a class `Grid` within the `MyCompany.Controls` namespace.
    - This version has a `Version` property set to "Version 2.0 - Advanced Features" and a `DisplayVersion()` method.

3.  **`AssemblyAliasDemo` (Console Application):**
    - References both `GridV1.dll` and `GridV2.dll`.
    - Uses `extern alias` to assign aliases `GridV1` to `GridV1.dll` and `GridV2` to `GridV2.dll`.
    - Demonstrates how to instantiate and use the `Grid` class from both assemblies using their respective aliases.

## Setup and Running the Demo

Follow these steps to build and run the demo:

1.  **Clone or Download the Repository:**

    ```bash
    git clone [repository_url]
    cd AssemblyAliasDemo
    ```

    (Replace `[repository_url]` with the actual URL if you are using a repository.)

2.  **Build the Class Libraries:**

    - Navigate to the `GridV1` directory and build the project (e.g., using `dotnet build` if you have the .NET CLI installed, or build through your IDE). This will generate `GridV1.dll` in the `bin/Debug` or `bin/Release` folder.
    - Navigate to the `GridV2` directory and build the project. This will generate `GridV2.dll`.

3.  **Build the Console Application:**

    - Navigate to the `AssemblyAliasDemo` directory and build the project.

4.  **Add Assembly References and Set Aliases (if not already done in the project file):**

    - Open the `AssemblyAliasDemo` project in your IDE (e.g., Visual Studio).
    - Add references to `GridV1.dll` and `GridV2.dll` (located in their respective `bin/Debug` or `bin/Release` folders).
    - For each added reference:
      - Select the reference in the Solution Explorer.
      - In the Properties window, change the **"Aliases"** property:
        - Set the alias for `GridV1.dll` to `GridV1`.
        - Set the alias for `GridV2.dll` to `GridV2`.

5.  **Run the Console Application:**
    - Execute the `AssemblyAliasDemo` application from your IDE or by navigating to its output directory (e.g., `AssemblyAliasDemo/bin/Debug/netX.X`) in the terminal and running the executable.

## Code Explanation (`AssemblyAliasDemo/Program.cs`)

```csharp
extern alias GridV1;
extern alias GridV2;

using System;

namespace AssemblyAliasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the full qualified names with aliases
            GridV1::MyCompany.Controls.Grid grid1 = new GridV1::MyCompany.Controls.Grid();
            GridV2::MyCompany.Controls.Grid grid2 = new GridV2::MyCompany.Controls.Grid();

            Console.WriteLine(<span class="math-inline">"Grid 1 Version\: \{grid1\.Version\}"\);
grid1\.DisplayVersion\(\);
Console\.WriteLine\(\);
Console\.WriteLine\(</span>"Grid 2 Version: {grid2.Version}");
            grid2.DisplayVersion();

            Console.ReadKey();
        }
    }
}
```
