# Partial Class Demo

This project demonstrates the use of partial classes in C#.

## Overview

The code defines a `Customer` class split into two partial definitions. This allows you to separate the properties and methods of a single class across multiple files or within the same file for better organization.

- The first part of the `Customer` class defines basic properties like `Id`, `FirstName`, and `LastName`, along with a `GetFullName()` method.
- The second part of the `Customer` class defines contact information properties like `Email` and `Phone`, and a `PrintContactInfo()` method.

The `Program` class in the `PartialClassDemo` namespace creates an instance of the `Customer` class, sets its properties, and then calls the methods defined in both partial parts of the class.

## Getting Started

1.  **Prerequisites:** Ensure you have the .NET SDK installed on your machine. You can download it from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

2.  **Clone the repository (optional):** If this code is part of a repository, clone it to your local machine.

    ```bash
    git clone <repository_url>
    cd <repository_directory>
    ```

3.  **Create a new .NET project (if starting from scratch):**

    ```bash
    dotnet new console -n PartialClassDemo
    cd PartialClassDemo
    ```

4.  **Replace the contents of `Program.cs` with the provided code.**

## Running the Code

1.  Navigate to the project directory in your terminal.

    ```bash
    cd PartialClassDemo
    ```

2.  Run the application using the .NET CLI:

    ```bash
    dotnet run
    ```

## Expected Output

When you run the application, you should see the following output in your console:
Full Name: John Doe
Email: john.doe@example.com, Phone: 123-456-7890

## Explanation of Partial Classes

Partial classes allow you to split the definition of a class, struct, interface, or record across multiple source files. The compiler combines all the parts when the application is compiled into a single type.

**Benefits of using partial classes:**

- **Improved Organization:** You can logically group related members of a class into separate files, making the code easier to manage and understand.
- **Team Collaboration:** Multiple developers can work on different parts of the same class simultaneously without interfering with each other's code.
- **Code Generation:** Partial classes are often used in scenarios involving code generation, where automatically generated code can be kept separate from manually written code. For example, designers in Visual Studio often use partial classes to separate the visual layout code from the business logic.

In this example, although both parts of the `Customer` class are in the same file, it effectively demonstrates how you can separate different aspects of the `Customer` entity (basic information vs. contact information) into logical blocks using the `partial` keyword. In larger projects, these partial definitions could reside in separate `.cs` files.
