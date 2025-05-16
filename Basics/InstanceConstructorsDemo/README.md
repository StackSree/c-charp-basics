# 🐼 Panda Constructor Demo in C#

This project demonstrates various types of constructors in C# using a `Panda` class. It showcases:

- **Public, internal, and private constructors**
- **Expression-bodied constructor**
- **Constructor with `this` keyword to disambiguate**
- **Static method to create an instance using a private constructor**

## 🧠 Concepts Illustrated

### ✅ Public Constructor

Used to instantiate objects from outside the class.

```csharp
public Panda(string n)
```

### 🛡️ Internal Constructor

Accessible only within the same assembly.

```csharp
internal Panda(int age)
```

### 🔒 Private Constructor

Can only be called from within the class, useful for patterns like factory methods.

```csharp
private Panda(string n, bool isFriendly)
```

### 🧾 Expression-Bodied Constructor

A concise way to assign fields during object initialization.

```csharp
public Panda(char initial) => name = $"Panda starting with {initial}";
```

### 🔁 Constructor with `this`

Used to avoid name conflicts and clarify assignments.

```csharp
public Panda(string name) => this.name = name;
```

### 🏭 Static Factory Method

Creates an instance using a private constructor.

```csharp
public static Panda CreateFriendlyPanda(string name)
```

## ▶️ Running the Program

When you run the application, you'll see output demonstrating the use of each constructor type:

```bash
Creating a Panda named Petey using the public constructor.
Hello, my name is Petey!

Creating a Panda with age 10 using the internal constructor.
Hello, my name is Panda aged 10!

Hello, my name is Panda starting with C!

Hello, my name is Another Petey!

Creating a Panda named Friendly (friendly: True) using the private constructor.
Hello, my name is Friendly!
```

> 💡 Note: Attempting to call the private constructor directly from outside the class will result in a **compilation error**.

## 📝 Author

Created to demonstrate constructor variations and access modifiers in C# for learning and educational purposes.
