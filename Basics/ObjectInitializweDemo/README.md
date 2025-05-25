# 🛰️ IoT Sensor Reading Demo with Object Initializers in C#

This is a simple C# console application that demonstrates how to use **Object Initializers** to represent real-time sensor readings in an IoT environment.

---

## 📦 Overview

The app simulates data coming from IoT sensors (e.g., temperature and humidity sensors like DHT11) and uses object initializers to populate the readings.

Object initializers allow you to create and initialize an object in a single, readable step — reducing boilerplate and improving clarity.

---

## ✅ Features

- Simulate readings from temperature and humidity sensors
- Use of both **parameterless** and **parameterized constructors**
- Object Initializers for clean, declarative instantiation
- Simple `PrintStatus()` method for formatted output

---

## 🚀 How It Works

### 1. Define the Model

```csharp
public class SensorReading
{
    public string DeviceId;
    public double Temperature;
    public double Humidity;
    public bool IsCritical;

    public SensorReading() { }

    public SensorReading(string deviceId)
    {
        DeviceId = deviceId;
    }

    public void PrintStatus()
    {
        Console.WriteLine($"Device: {DeviceId}");
        Console.WriteLine($"Temperature: {Temperature} °C");
        Console.WriteLine($"Humidity: {Humidity} %");
        Console.WriteLine($"Critical: {(IsCritical ? "Yes" : "No")}");
        Console.WriteLine(new string('-', 30));
    }
}
```

---

### 2. Create Objects Using Initializers

```csharp
SensorReading reading1 = new SensorReading
{
    DeviceId = "DHT11-A1",
    Temperature = 28.5,
    Humidity = 60.2,
    IsCritical = false
};

SensorReading reading2 = new SensorReading("DHT11-B7")
{
    Temperature = 45.1,
    Humidity = 80.5,
    IsCritical = true
};
```

---

## 🔍 Under the Hood: What Happens

### reading1: Using Parameterless Constructor

```csharp
SensorReading temp = new SensorReading();
temp.DeviceId = "DHT11-A1";
temp.Temperature = 28.5;
temp.Humidity = 60.2;
temp.IsCritical = false;
SensorReading reading1 = temp;
```

### reading2: Using Constructor with Parameter

```csharp
SensorReading temp = new SensorReading("DHT11-B7");
temp.Temperature = 45.1;
temp.Humidity = 80.5;
temp.IsCritical = true;
SensorReading reading2 = temp;
```

> The compiler creates a temporary object, applies the field/property initializations, and then assigns it to the target variable. This ensures safe and complete initialization.

---

## 🧪 Sample Output

```
Device: DHT11-A1
Temperature: 28.5 °C
Humidity: 60.2 %
Critical: No
------------------------------
Device: DHT11-B7
Temperature: 45.1 °C
Humidity: 80.5 %
Critical: Yes
------------------------------
```

---

## ⚙️ Use Cases

- Mocking or simulating sensor data in development or unit tests
- Configuring IoT devices with predefined state
- Declarative setup of models in data-driven apps (e.g., WPF, MAUI, ASP.NET)

---

## 📚 Learn More

- [Microsoft Docs – Object and Collection Initializers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)
- [IoT device patterns with C# and .NET](https://learn.microsoft.com/en-us/dotnet/iot/)

---

## 🛠️ Requirements

- .NET 6.0 or later
- C# 9.0+ for concise expression-bodied members (optional)

---

## ✨ Tip

You can extend this by:

- Adding serialization (e.g., to JSON for cloud uploads)
- Integrating with live sensors using `System.Device.Gpio`
- Adding real-time charts with `LiveCharts` or `ScottPlot`

---

## 📬 License

MIT – free to use and modify.

```


```
