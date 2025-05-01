# 🆕 C# `new` Inheritance Modifier Example

This C# example demonstrates how the `new` keyword is used to **hide** a non-virtual method from a base class when it is redefined in a derived class.

## 📌 Focus: `new` Inheritance Modifier

In C#, when a derived class defines a method with the same name as a method in its base class, and the base method is **not virtual**, the derived method hides the base method. The `new` keyword is used to **explicitly indicate** this behavior.

### Key Characteristics

- **Method hiding** is not polymorphic.
- The method called is based on the **static type** of the variable, not the runtime type of the object.

---

## 🧩 Code Overview

```csharp
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Dog : Animal
{
    public new void Eat()
    {
        Console.WriteLine("Dog is eating a bone.");
    }
}
```

### Usage in `Main()`

```csharp
Animal animal = new Animal();
Dog dog = new Dog();
Animal animalAsDog = new Dog();

animal.Eat();        // Output: Animal is eating.
dog.Eat();           // Output: Dog is eating a bone.
animalAsDog.Eat();   // Output: Animal is eating.
```

### Explanation

| Variable            | Runtime Type | Method Called  | Output                | Why?                                                                               |
| ------------------- | ------------ | -------------- | --------------------- | ---------------------------------------------------------------------------------- |
| `animal.Eat()`      | `Animal`     | `Animal.Eat()` | Animal is eating.     | Direct call to base method.                                                        |
| `dog.Eat()`         | `Dog`        | `Dog.Eat()`    | Dog is eating a bone. | Calls hidden method from `Dog`.                                                    |
| `animalAsDog.Eat()` | `Dog`        | `Animal.Eat()` | Animal is eating.     | Method is **not virtual**, so method is resolved by **reference type** (`Animal`). |

---

## ✅ Summary

- Use `new` to **hide** a base class method intentionally.
- Hidden methods are **not polymorphic**; they do not participate in runtime method overriding.
- Always consider if you **really** need to hide a method. If you want polymorphic behavior, prefer using `virtual` and `override`.
