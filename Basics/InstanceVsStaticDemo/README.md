# C# Instance vs. Static Members Demo

## Concepts Illustrated

* **Instance Members:**
    * These members belong to individual objects (instances) of a class.
    * Each instance maintains its own copy of instance fields and properties.
    * Accessed using an object's reference (e.g., `obj.instanceValue`).
* **Static Members:**
    * These members belong to the class itself, not to any specific instance.
    * All instances of the class share the same static members.
    * Accessed using the class name (e.g., `MyClass.staticValue`).

## Code Overview

The `InstanceVsStaticDemo` namespace contains:

* **`Program.cs`:**
    * The `Main` method, which serves as the entry point of the application.
    * Demonstrates the creation of `MyClass` instances.
    * Illustrates how instance and static members are accessed and modified.
    * Contains helpful comments explaining the various aspects of the Main method, and common Main method declarations.
* **`MyClass.cs`:**
    * Defines the `MyClass` class.
    * Contains `instanceValue` (instance field), `staticValue` (static field), `InstanceMethod()` (instance method), and `StaticMethod()` (static method).

## Key Observations

* Changes to instance members affect only the specific object instance.
* Changes to static members affect all instances of the class.
* The comments in the Main method explain common Main method signatures and features.

## Code Snippets and Explanations

```csharp
// Setting instance values
obj1.instanceValue = 10;
obj2.instanceValue = 20;

// Setting static value
MyClass.staticValue = 100;

This snippet shows how instance and static fields are assigned values.
// Calling instance methods
obj1.InstanceMethod();
obj2.InstanceMethod();

// Calling static method
MyClass.StaticMethod();


This snippet demonstrates how instance and static methods are called.
// Changing static value
MyClass.staticValue = 200;

// Calling instance methods again to show the change
obj1.InstanceMethod();
obj2.InstanceMethod();

This example will help you understand the core differences between instance and static members in C#.