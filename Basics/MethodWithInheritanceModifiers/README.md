# IoT Sensor Inheritance Modifiers Demo

This project is a C# console application that simulates an IoT temperature monitoring system and demonstrates the use of **inheritance modifiers** in C#:

- `abstract`
- `virtual`
- `override`
- `sealed`
- `new`

## 🧠 Concept

The goal is to showcase how different inheritance behaviors work using a sensor-monitoring scenario:

- A **base sensor** class defines the contract for temperature readings.
- Derived sensor classes override, seal, or hide behavior to simulate different sensor types.
- A central hub continuously monitors sensor data and triggers alerts.

## 🏗️ Structure

### Classes Overview

| Class Name          | Role                                            | Modifiers Used       |
| ------------------- | ----------------------------------------------- | -------------------- |
| `BaseSensor`        | Abstract base class for all sensors             | `abstract`           |
| `TemperatureSensor` | Concrete sensor providing default readings      | `override`           |
| `AdvancedSensor`    | Calibrates readings, prevents further overrides | `override`, `sealed` |
| `FakeSensor`        | Hides base method to simulate fake sensor       | `new`                |
| `CentralHub`        | Monitors temperature from any sensor            | —                    |
| `Program`           | Main entry point, sets up and starts monitoring | —                    |

## 🚀 How to Run

### Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6 or later recommended)

### Steps

```bash
# Create a new console project
dotnet new console -n MethodWithInheritanceModifiers
cd MethodWithInheritanceModifiers

# Replace Program.cs with the provided code
# Then run the project
dotnet run
```

````

## 🔍 Sample Output

```
--- IoT Sensor Inheritance Modifiers Demo ---
[TemperatureSensor] Raw Temp: 22
[AdvancedSensor] Calibrated Temp: 23
[CentralHub] Current Temp: 23°C
...
** ALERT! Temp exceeded 25°C — Current: 27°C **
```

## 💡 What You Learn

| Modifier   | Behavior                              |
| ---------- | ------------------------------------- |
| `abstract` | Forces derived classes to implement   |
| `virtual`  | Allows method to be overridden        |
| `override` | Replaces base method in derived class |
| `sealed`   | Prevents further overrides            |
| `new`      | Hides base method with new behavior   |

## 📁 Files

- `Program.cs` – Contains all classes in a single file for demo purposes

## 📜 License

This code is provided for learning and demonstration purposes. Free to use and adapt.
````
