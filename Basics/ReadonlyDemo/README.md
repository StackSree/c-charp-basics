# C# readonly Modifier Example

This project demonstrates the use of the `readonly` modifier in C# with a simple `Configuration` class.

## Overview

The `readonly` modifier allows you to define fields in a class or struct that can only be assigned a value during their declaration or within the constructor. This ensures that once initialized, these fields maintain their value throughout the object's lifetime.

## Code Example

The `Configuration` class in this example showcases several `readonly` fields:

- `DatabaseServer`: A string representing the database server address.
- `MaxConnections`: An integer defining the maximum number of connections.
- `InitializationTime`: A `DateTime` indicating when the configuration was initialized.
- `AllowedUsers`: A `List<string>` holding the users allowed to access the system.

```csharp
using System;
using System.Collections.Generic;

public class Configuration
{
    public readonly string DatabaseServer;
    public readonly int MaxConnections;
    public readonly DateTime InitializationTime;
    public readonly List<string> AllowedUsers; // Reference type

    public Configuration(string server, int connections)
    {
        DatabaseServer = server;
        MaxConnections = connections;
        InitializationTime = DateTime.Now;
        AllowedUsers = new List<string>();
        AllowedUsers.Add("Admin");
    }

    public void AddUser(string user)
    {
        AllowedUsers.Add(user); // Modifying the state of the referenced object is allowed
    }
}

public class ReadonlyDemo
{
    public static void Main(string[] args)
    {
        Configuration config1 = new Configuration("server1.example.com", 10);
        Console.WriteLine(<span class="math-inline">"Config 1 \- Server\: \{config1\.DatabaseServer\}, Max Connections\: \{config1\.MaxConnections\}, Initialized\: \{config1\.InitializationTime\}"\);
config1\.AddUser\("User1"\);
Console\.WriteLine\(</span>"Config 1 - Allowed Users: {string.Join(", ", config1.AllowedUsers)}");

        Configuration config2 = new Configuration("server2.example.net", 20);
        Console.WriteLine(<span class="math-inline">"Config 2 \- Server\: \{config2\.DatabaseServer\}, Max Connections\: \{config2\.MaxConnections\}, Initialized\: \{config2\.InitializationTime\}"\);
Console\.WriteLine\(</span>"Config 2 - Allowed Users: {string.Join(", ", config2.AllowedUsers)}");

        // The following lines would cause compile-time errors:
        // config1.DatabaseServer = "new.server.com";
        // config1.MaxConnections = 15;
        // config1.InitializationTime = DateTime.MinValue;
        // config1.AllowedUsers = new List<string>(); // Cannot reassign the list

        Console.ReadKey();
    }
}


## Comparison with `const`

While both `readonly` and `const` are used to create fields whose values cannot be changed after initialization, there are key differences:

| Feature           | `readonly`                                                | `const`                                                    |
| ----------------- | --------------------------------------------------------- | ---------------------------------------------------------- |
| **Value Assignment** | During declaration or within the constructor.           | Must be assigned a value during declaration.               |
| **Timing of Value** | Runtime (can be different for each instance).           | Compile-time (value must be known at compile time).        |
| **Scope** | Instance members (non-static by default).                | Static members (implicitly static).                        |
| **Usage Scenarios** | Values that are determined during object creation.      | True constants, known at compile time (e.g., Math.PI).     |
| **Reference Types** | Prevents reassignment of the reference, but object state can be modified (if not immutable). | For value types only (structs, enums, primitive types). Reference types cannot be `const` in the same way. |

**In essence:**

* Use `const` for values that are truly constant and known at compile time across all instances of a class.
* Use `readonly` for values that need to be immutable after an object is created but might be different for each instance or whose value is determined during runtime (e.g., based on constructor parameters or system time).
```
