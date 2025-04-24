# Sealed Console Application in C#

This simple console application demonstrates the use of the `sealed` keyword in C#.

## Overview

The application defines a `sealed` class named `ConfigurationSettings`.
This class holds basic application configuration such as the database server address and the log file path.
Because it's sealed, no other class can inherit from `ConfigurationSettings`.

The `Program` class then creates an instance of `ConfigurationSettings` and displays the configured settings to the console.

## Code Structure

- **`SealedConsoleApp` Namespace:** Organizes the application code.
- **`ConfigurationSettings` Class (sealed):**
  - Contains read-only properties: `DatabaseServer` and `LogFilePath`.
  - The constructor initializes these properties.
  - The `DisplaySettings()` method prints the configuration to the console.
- **`Program` Class:**
  - The `Main` method is the entry point of the application.
  - It creates an instance of `ConfigurationSettings` and calls `DisplaySettings()` to show the output.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.

### Running the Application

1.  **Save the code:** Save the provided C# code as a `.cs` file (e.g., `SealedApp.cs`).
2.  **Open a terminal or command prompt:** Navigate to the directory where you saved the file.
3.  **Compile the code:** Use the .NET CLI to build the application:
    ```bash
    dotnet build
    ```
4.  **Run the application:** Execute the compiled application:
    ```bash
    dotnet run
    ```

## Output

Upon running the application, you will see the following output in the console:
Database Server: localhost
Log File Path: /var/log/app.log

Press any key to exit...

## Purpose of `sealed`

The `sealed` keyword in C# prevents inheritance from a class.
In this example, `ConfigurationSettings` is sealed because it represents a specific and final set of application configurations.
There's likely no need for other classes to extend or modify these fundamental settings through inheritance.
This helps maintain the intended structure and behavior of the `ConfigurationSettings` class.
