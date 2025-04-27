# StringHelper Utility Class

This project contains a simple `static` class in C# called `StringHelper`, providing utility functions for string manipulation.

## Overview

The `StringHelper` class currently includes the following functionalities:

- **`ReverseString(string input)`:** Reverses the characters of a given input string. Returns `null` if the input is `null`.
- **`IsPalindrome(string input)`:** Checks if a given input string is a palindrome (reads the same forwards and backward), ignoring case. Returns `false` if the input is `null`.

The `Example` class demonstrates how to use these utility methods directly without creating an instance of the `StringHelper` class.

## Getting Started

1.  **Prerequisites:** Ensure you have the .NET SDK installed on your machine. You can download it from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

2.  **Clone the Repository (Optional):** If you have this code in a repository, you can clone it to your local machine.

    ```bash
    git clone <repository_url>
    cd <repository_directory>
    ```

3.  **Create a New Project (If starting from scratch):** If you don't have an existing project, create a new console application:

    ```bash
    dotnet new console -o StringHelperDemo
    cd StringHelperDemo
    ```

4.  **Replace `Program.cs`:** Replace the contents of your `Program.cs` file with the C# code provided below:

    ```csharp
    public static class StringHelper
    {
        public static string ReverseString(string input)
        {
            if (input == null)
            {
                return null;
            }
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool IsPalindrome(string input)
        {
            if (input == null)
            {
                return false;
            }
            string reversed = ReverseString(input);
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            string original = "hello";
            string reversed = StringHelper.ReverseString(original);
            Console.WriteLine($"Original: {original}, Reversed: {reversed}");

            string palindrome = "racecar";
            bool isPal = StringHelper.IsPalindrome(palindrome);
            Console.WriteLine($"'{palindrome}' is a palindrome: {isPal}");
        }
    }
    ```

5.  **Run the Application:** Navigate to the project directory in your terminal and run the application:

    ```bash
    dotnet run
    ```

    You should see the following output:

    ```
    Original: hello, Reversed: olleh
    'racecar' is a palindrome: True
    ```

## Significance

The `StringHelper` class demonstrates the use of `static` classes in C#. Key aspects highlighted are:

- **Utility Functions:** Grouping related utility methods that don't require instance-specific state.
- **Direct Access:** Accessing methods directly using the class name (e.g., `StringHelper.ReverseString(...)`).
- **Code Organization:** Providing a clear and organized way to handle string-related operations.

## Pros and Cons of Using Static Classes (as Demonstrated)

**Pros:**

- **Direct Access:** Easy and intuitive way to call utility functions.
- **No Object Creation Overhead:** Avoids the need to instantiate the class, offering slight performance benefits for simple utilities.
- **Namespace Clarity:** Keeps related functions grouped under a logical class name.

**Cons:**

- **Limited Flexibility:** Cannot be instantiated or used in polymorphic scenarios.
- **Tight Coupling Potential:** Over-reliance can make code harder to test and refactor in larger applications.
- **No Instance State:** Not suitable for operations requiring object-specific data.

## Further Development

This is a basic example. The `StringHelper` class could be extended with more string manipulation utilities, such as:

- Converting string case.
- Checking for anagrams.
- Formatting strings.

Feel free to contribute or expand upon this utility class!
