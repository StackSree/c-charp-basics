# ImplicitConstructorDemo

This is a simple C# console application that demonstrates the concept of **implicit** and **explicit constructors** in C# classes.

## Overview

In C#, if no constructor is explicitly defined in a class, the compiler automatically provides a **public parameterless constructor**. However, if a constructor is explicitly defined (especially with parameters), the compiler does **not** generate a default constructor. This can lead to compile-time errors if you attempt to use a parameterless constructor that doesn't exist.

This demo contains two classes:

- `WithoutExplicitConstructor`: Does **not** define any constructor, so a parameterless one is implicitly provided.
- `WithExplicitConstructor`: Defines a constructor that takes an integer parameter. Because of this, the compiler does **not** generate a default parameterless constructor.

## Code Behavior

- An instance of `WithoutExplicitConstructor` is successfully created using the implicit parameterless constructor.
- An instance of `WithExplicitConstructor` **must** be created by providing a parameter to the defined constructor. Attempting to instantiate it without a parameter will result in a compile-time error (as shown in the commented-out code).

## Sample Output

```text
Demonstrating Implicit Parameterless Constructor:
Object 1 Value: 10
Object 3 Value: 20
```
