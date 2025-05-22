# IoT Sensor Data Manager Demo

This demo showcases two fundamental design patterns in C#:

- **Singleton Pattern** — for centralized sensor data collection and management.
- **Factory Method Pattern** — for creating different types of IoT devices without exposing the instantiation logic to the client.

---

## 🚀 Features

### 1. SensorDataManager (Singleton)

A thread-safe singleton implementation that:

- Restricts direct instantiation using a **private constructor**.
- Manages sensor data from multiple sensors.
- Ensures only one instance is used application-wide.
- Simulates real-time data collection and processing.

### 2. DeviceFactory (Factory Method)

- Abstracts creation of various IoT devices such as **Temperature** and **Humidity** sensors.
- Uses internal constructors and static factory methods to control device creation.
- Demonstrates clean separation of responsibilities and future extensibility.

---

## 🧱 Architecture Overview

```text
+---------------------+              +---------------------------+
|     Program.cs      |              |     SensorDataManager     |
|---------------------|              |---------------------------|
| - Uses Singleton     |<----------->| - Singleton Instance       |
| - Uses Factory       |              | - Collect/Process Data     |
+---------------------+              +---------------------------+

+---------------------+              +---------------------------+
|     DeviceFactory    |------------>|   TemperatureSensorDevice  |
|---------------------|              +---------------------------+
| - Factory Method     |             |   HumiditySensorDevice     |
| - Centralized Logic  |------------>|   (implements IotDevice)   |
+---------------------+              +---------------------------+
```

````

---

## 🧪 Demo Output

### Singleton Usage

```plaintext
Attempting to get the first SensorDataManager instance...
[SensorDataManager] Instance created (private constructor called).
[SensorDataManager] Initializing sensor data processing system...
[SensorDataManager] Initialization complete.
[SensorDataManager] Collected: TempSensor001: 23.5°C
...

Are manager1 and manager2 the same instance? True
--- Processing All Sensor Readings ---
...
```

### Factory Method Usage

```plaintext
[DeviceFactory] Creating device of type 'TemperatureSensor' with ID 'THS-ROOM-001'...
[TemperatureSensorDevice] Created device ID: THS-ROOM-001
...
Error creating device: Unsupported device type: PressureSensor
```

---

## 🛠️ How to Run

1. Clone the repository or copy the code into a `.NET` project.
2. Build and run the application using your IDE or via CLI:

   ```bash
   dotnet run
   ```

---

## 🧠 Key Concepts Demonstrated

| Concept               | Purpose                                                           |
| --------------------- | ----------------------------------------------------------------- |
| `private constructor` | Prevents external instantiation (for Singleton & Factory devices) |
| `static method`       | Controls access to instance or creation logic                     |
| `lock`                | Ensures thread safety in singleton access                         |
| `abstract class`      | Defines a contract for IoT devices                                |
| `switch` statement    | Used in factory to create different device types                  |

---

## 📦 Future Enhancements

- Add support for more device types (e.g., PressureSensor, LightSensor).
- Persist sensor data to a database or cloud.
- Extend telemetry communication to use actual network protocols.

---

## 📚 Design Patterns Used

- **Singleton**: `SensorDataManager.GetInstance()` ensures a single data manager.
- **Factory Method**: `DeviceFactory.CreateDevice()` encapsulates object creation logic.

---

## 📝 License

This project is provided for educational purposes. Feel free to modify and reuse.
````
