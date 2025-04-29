# Counter Class Demo in C#

This project demonstrates the use of the `static` modifier for fields in C#. It includes a simple `Counter` class with both static and instance fields to illustrate their behavior.

## Overview

The `Counter` class keeps track of the number of `Counter` objects created and also maintains a separate count for each individual instance.

- **`static int TotalCount`**: A static field that belongs to the `Counter` class itself. It keeps track of the total number of `Counter` objects that have been instantiated. There is only one copy of this field shared across all instances.
- **`int InstanceCount`**: An instance field that belongs to each individual `Counter` object. Each object has its own separate `InstanceCount`.
- **Constructor (`Counter()`)**: When a new `Counter` object is created, the `InstanceCount` is initialized to 0, and the `TotalCount` (the static field) is incremented.
- **`IncrementInstanceCount()`**: An instance method that increments the `InstanceCount` for the specific `Counter` object it is called on.
- **`static void DisplayTotalCount()`**: A static method that can be called directly on the `Counter` class (without needing an instance). It displays the current value of the `TotalCount`.

The `Demo` class in the `Program.cs` file demonstrates how to create `Counter` objects and interact with both the static and instance members.

## Getting Started

1.  **Clone the repository** (if applicable) or create a new C# console application project in your preferred IDE (like Visual Studio or Visual Studio Code).
2.  **Create a `Counter.cs` file** and paste the following code into it:

    ```csharp
    using System;

    public class Counter
    {
        // Static field to keep track of the total count across all Counter objects
        public static int TotalCount;

        // Instance field to keep track of the count for a specific Counter object
        public int InstanceCount;

        public Counter()
        {
            InstanceCount = 0;
            TotalCount++; // Increment the static counter when a new Counter object is created
        }

        public void IncrementInstanceCount()
        {
            InstanceCount++;
        }

        public static void DisplayTotalCount()
        {
            Console.WriteLine($"Total Counter instances created: {TotalCount}");
        }
    }
    ```

3.  **Open your `Program.cs` file** and replace its contents with the following code:

    ```csharp
    using System;

    public class Demo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Initial Total Count: {Counter.TotalCount}"); // Accessing static field using the class name

            Counter counter1 = new Counter();
            Console.WriteLine($"Counter 1 Instance Count: {counter1.InstanceCount}, Total Count: {Counter.TotalCount}");

            Counter counter2 = new Counter();
            Console.WriteLine($"Counter 2 Instance Count: {counter2.InstanceCount}, Total Count: {Counter.TotalCount}");

            counter1.IncrementInstanceCount();
            Console.WriteLine($"Counter 1 Instance Count after increment: {counter1.InstanceCount}, Total Count: {Counter.TotalCount}");

            Counter.DisplayTotalCount(); // Accessing the static method using the class name
        }
    }
    ```

4.  **Build and run the project.** You should see the following output in your console:

    ```
    Initial Total Count: 0
    Counter 1 Instance Count: 0, Total Count: 1
    Counter 2 Instance Count: 0, Total Count: 2
    Counter 1 Instance Count after increment: 1, Total Count: 2
    Total Counter instances created: 2
    ```

## Explanation of the Output

- The initial `Total Count` is 0 because no `Counter` objects have been created yet.
- When `counter1` is created, `Total Count` becomes 1. Its `Instance Count` is initialized to 0.
- When `counter2` is created, `Total Count` becomes 2. Its `Instance Count` is initialized to 0.
- Incrementing `counter1.InstanceCount` only affects the `InstanceCount` of `counter1`. The `Total Count` remains 2.
- Finally, `Counter.DisplayTotalCount()` shows the total number of `Counter` instances created, which is 2.

This demonstrates that the `static TotalCount` field is shared across all instances, while each instance has its own independent `InstanceCount`.

## Further Exploration

You can experiment further by:

- Creating more `Counter` objects and observing how `TotalCount` changes.
- Creating multiple instances and calling `IncrementInstanceCount()` on each to see how their individual `InstanceCount` values are affected.
- Trying to access the static `TotalCount` through different instances and verifying that they all reflect the same value.

This simple example provides a basic understanding of how the `static` modifier works for fields in C#. Static members are often used for utility methods, constants, or shared state across all instances of a class.
