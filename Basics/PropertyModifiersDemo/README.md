```markdown
# 🔧 C# Properties with Modifiers – Console App Demo

This project demonstrates how to use **C# properties** with various **modifiers**, including access modifiers, static, inheritance-related keywords, and more. It's a concise console app that helps developers understand the capabilities of properties in object-oriented programming.

---

## 📌 Features Demonstrated

| Modifier Type       | Modifiers Used                         |
| ------------------- | -------------------------------------- |
| Static              | `static`                               |
| Access              | `public`, `protected`, `private`       |
| Inheritance         | `virtual`, `override`                  |
| Read-Only Property  | `private set`                          |
| (Advanced/Optional) | `unsafe`, `extern` (not shown in demo) |

---

## 🏗️ Project Structure
```

/PropertyModifiersDemo
├── Program.cs # Entry point
├── Sensor.cs # Base class with properties
└── AdvancedSensor.cs # Derived class with overridden property

````

---

## ✅ Code Overview

### 🔸 Sensor.cs

```csharp
public class Sensor
{
    // Static property shared across all instances
    public static string DeviceType { get; set; } = "Temperature Sensor";

    // Protected virtual property to allow overriding
    protected virtual double Value { get; set; } = 25.5;

    public void ShowValue()
    {
        Console.WriteLine($"Base Value: {Value}");
    }
}
````

### 🔸 AdvancedSensor.cs

```csharp
public class AdvancedSensor : Sensor
{
    // Override the protected base property
    protected override double Value
    {
        get { return base.Value + 5; }
        set { base.Value = value - 2; }
    }

    // Read-only property using private setter
    public string SensorName { get; private set; } = "AdvancedSensorX";
}
```

### 🔸 Program.cs

```csharp
class Program
{
    static void Main()
    {
        Console.WriteLine($"Device Type: {Sensor.DeviceType}");

        Sensor sensor = new Sensor();
        sensor.ShowValue(); // Output: 25.5

        AdvancedSensor advSensor = new AdvancedSensor();
        advSensor.ShowValue(); // Output: 30.5

        Console.WriteLine($"Sensor Name: {advSensor.SensorName}");
    }
}
```

---

## 🧠 Under the Hood

- The `static` property `DeviceType` is shared across all instances.
- The `virtual` property `Value` in `Sensor` is overridden in `AdvancedSensor`.
- The `SensorName` property uses a `private set`, making it **read-only from outside**.
- You cannot directly set `SensorName` from outside the class.

---

## 💻 Output

```
Device Type: Temperature Sensor
Base Value: 25.5
Base Value: 30.5
Sensor Name: AdvancedSensorX
```

---

## 🔐 Why Modifiers Matter in Properties

| Modifier      | Purpose                            |
| ------------- | ---------------------------------- |
| `public`      | Makes property accessible anywhere |
| `private`     | Hides setter from external code    |
| `protected`   | Allows access in derived classes   |
| `static`      | No object needed to access         |
| `virtual`     | Allows customization in subclasses |
| `override`    | Customizes base logic              |
| `private set` | Useful for read-only public APIs   |

---

## 🚧 Requirements

- .NET 6.0 SDK or later
- C# 9.0 or higher

---

## 📚 Further Reading

- [C# Properties Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- [C# Access Modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [Object-Oriented Programming in C#](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop)

---

## 📜 License

MIT License — Free to use, modify, and distribute.

---

## 💬 Questions?

Feel free to open an issue or reach out if you'd like to see examples using `unsafe`, `extern`, or in GUI frameworks like WPF or WinForms.

```


```
