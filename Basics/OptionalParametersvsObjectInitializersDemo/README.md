# 🐇 Bunny Demo in C#

This project demonstrates the difference between using **optional parameters in constructors** and **object initializers with `init`-only properties** in C#.

## 🔧 Features

- `Bunny`: Uses a constructor with optional parameters.
- `BunnyWithInitOnly`: Uses object initializers and the `init` modifier (introduced in C# 9.0).

---

## 💡 What is `init`?

The `init` accessor in C# 9 allows properties to be set **only during object initialization**, ensuring they are **immutable** afterward — similar to read-only fields set in a constructor.

```csharp
public string Name { get; init; }
```

This enables the use of **object initializers** while still maintaining immutability, previously only possible via constructors.

---

## 🆚 Optional Parameters vs Object Initializers

| Feature                       | Optional Parameters (Constructor)           | Object Initializers (`init`)                  |
| ----------------------------- | ------------------------------------------- | --------------------------------------------- |
| ✅ Read-only support          | Yes (via constructor assignment)            | Yes (via `init`-only properties)              |
| 🔄 Ease of extension          | ❌ Difficult (adding params breaks callers) | ✅ Easy to extend with new properties         |
| 🧩 Binary compatibility       | ❌ Risky (values are compiled into caller)  | ✅ Safe (compiler generates property setters) |
| 🧬 Subclassing flexibility    | ❌ Constructor chaining required            | ✅ Simpler, avoids constructor overloads      |
| 🧼 Cleaner syntax             | ⚠ Verbose with many optional parameters     | ✅ Clean and self-documenting                 |
| 🧪 Nondestructive mutation    | ❌ Hard to implement                        | ✅ Easier with `with` expressions in records  |
| ⛓ Control over initialization | ✅ Centralized in constructor               | ⚠ Decentralized, relies on dev discipline     |

---

## 📦 Example Output

```
Bunny b1: Bo, LikesCarrots: True, LikesHumans: False
Bunny b2: Luna, LikesCarrots: False, LikesHumans: True
```

---

## 📁 Code Overview

### Bunny.cs (with optional parameters)

```csharp
public Bunny(string name, bool likesCarrots = false, bool likesHumans = false)
```

### BunnyWithInitOnly.cs (with `init`)

```csharp
public string Name { get; init; }
```

---

## 📌 Summary

- **Use optional parameters** when:

  - You want stricter control via constructors.
  - You're working in a closed system with no external consumers.

- **Use object initializers with `init`** when:

  - You want flexibility, immutability, and future-proof APIs.
  - You're designing public libraries or evolving class definitions.

---

## 🧠 Recommended Reading

- [C# 9.0 Features – Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9)
- [Records and init-only properties](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/init)

```

```
