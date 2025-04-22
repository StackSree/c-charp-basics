# Simple Console Application with Abstract Class in C#

This project demonstrates the use of abstract classes in a simple C# console application. It features an abstract `Greeter` class and two concrete implementations: `FormalGreeter` and `CasualGreeter`.

## Overview

The application prompts the user for their name and then displays two greetings: one formal and one casual, using the provided name. It illustrates the concepts of:

- **Abstraction:** Defining a general concept (`Greeter`) without specifying the exact implementation.
- **Abstract Methods:** Declaring methods (`Greet()`) in the abstract class that derived classes must implement.
- **Inheritance:** Creating concrete classes (`FormalGreeter`, `CasualGreeter`) that inherit from the abstract base class.
- **Polymorphism:** Treating objects of different derived classes through a common base class reference.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.

### Running the Application

1.  **Clone or download the repository (if applicable).** If you have the code in a repository, clone it to your local machine. If you've copied the code directly into files, ensure you have the `AbstractApp.cs` file in a directory.

2.  **Navigate to the project directory:** Open your terminal or command prompt and navigate to the directory containing the `AbstractApp.cs` file.

3.  **Build the application:** Run the following command:

    ```bash
    dotnet build
    ```

    This command compiles the C# code.

4.  **Run the application:** After a successful build, execute the application using:

    ```bash
    dotnet run
    ```

    The application will then prompt you to enter your name.

## Usage

1.  When the application runs, you will see the following prompt:

    ```
    Enter a name:
    ```

2.  Type your name and press Enter.

3.  The application will then display two greetings: a formal one and a casual one, using the name you entered. For example, if you enter "Alice", the output might look like this:

    ```
    Enter a name:
    Sreekanth

    Formal Greeting:
    Greetings, esteemed Sreekanth. It is a pleasure to make your acquaintance.

    Casual Greeting:
    Hey Sreekanth! What's up?

    Another Formal Greeting:
    Greetings, esteemed Professor Higgins. It is a pleasure to make your acquaintance.

    Another Casual Greeting:
    Hey Buddy! What's up?

    Press any key to exit...
    ```

4.  Press any key to close the application.

## Code Structure

- **`Greeter.cs` (or within `AbstractApp.cs`):** Contains the abstract `Greeter` class with an abstract `Greet()` method and a concrete `PerformGreeting()` method.
- **`FormalGreeter.cs` (or within `AbstractApp.cs`):** A concrete class that inherits from `Greeter` and provides a formal implementation of the `Greet()` method.
- **`CasualGreeter.cs` (or within `AbstractApp.cs`):** A concrete class that inherits from `Greeter` and provides a casual implementation of the `Greet()` method.
- **`AbstractApp.cs`:** Contains the `Main` method that demonstrates the usage of the abstract class and its derived classes.

## Learning Points

This simple application highlights the following important object-oriented programming (OOP) concepts:

- **Abstract Classes:** Cannot be instantiated directly and serve as blueprints for derived classes. They can contain both abstract and concrete members.
- **Abstract Methods:** Declare a method signature without providing an implementation. Subclasses must override and implement these methods.
- **Inheritance:** Allows derived classes to inherit properties and methods from a base class, promoting code reuse and establishing an "is-a" relationship.
- **Polymorphism:** Enables treating objects of different classes uniformly through a common interface (in this case, the abstract `Greeter` class).

## Contributing

Contributions to this simple example are welcome. Feel free to fork the repository and submit pull requests with improvements or suggestions.

## License

This project is open-source and available under the [MIT License](LICENSE) (add a `LICENSE` file if you intend to specify a license).
