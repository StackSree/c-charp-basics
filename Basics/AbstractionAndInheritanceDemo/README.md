# C# Program Demonstrating Inheritance and Abstraction

## 📌 Overview
This C# program showcases **both Inheritance and Abstraction** in Object-Oriented Programming (OOP).  
- **Inheritance**: A derived class (`Dog`) inherits properties and methods from the base class (`Animal`).  
- **Abstraction**: An abstract class (`Animal`) enforces a contract where derived classes must implement specific methods.  

---

## 🚀 Features
- Uses an **abstract class (`Animal`)** with an abstract method (`MakeSound()`).
- Implements the abstract method in a **derived class (`Dog`)**.
- Inherits a concrete method (`Eat()`) from the abstract class.
- Demonstrates both **code reuse** and **method enforcement**.

---

## 📜 Code Explanation
### **1️⃣ Abstract Class (`Animal`)**
- Contains an **abstract method** `MakeSound()` that must be implemented in any derived class.
- Has a **concrete method** `Eat()` that provides common functionality.

### **2️⃣ Derived Class (`Dog`)**
- **Inherits** from `Animal` (demonstrating **inheritance**).
- **Implements** the abstract method `MakeSound()` (demonstrating **abstraction**).

### **3️⃣ Main Method (`Program`)**
- Creates an instance of `Dog`.
- Calls both `MakeSound()` (overridden method) and `Eat()` (inherited method).

---

## 🖥️ Code
```csharp
using System;

abstract class Animal  // Abstract class (Abstraction)
{
    public abstract void MakeSound(); // Abstract method (must be implemented in derived class)

    public void Eat() // Concrete method (can be inherited)
    {
        Console.WriteLine("This animal eats food.");
    }
}

// Dog class inherits from Animal (Inheritance)
class Dog : Animal
{
    public override void MakeSound() // Implementing the abstract method (Abstraction)
    {
        Console.WriteLine("Dog barks!");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog(); // Creating object of derived class
        myDog.MakeSound(); // Calls overridden method
        myDog.Eat(); // Calls inherited method
    }
}
```

---

## 📌 Expected Output
```
Dog barks!
This animal eats food.
```

---

## ✅ Key Takeaways
- **Abstraction** ensures that all derived classes implement `MakeSound()`.
- **Inheritance** allows the `Dog` class to reuse the `Eat()` method.
- **Encapsulation** is maintained by keeping implementation details hidden.

---

## 🔗 More Information
- [Microsoft Docs - Inheritance](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance)
- [Microsoft Docs - Abstraction](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members)

---

### 📢 Happy Coding! 🚀
```