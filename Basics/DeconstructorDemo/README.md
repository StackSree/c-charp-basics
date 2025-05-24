# 📡 IoT Sensor Deconstructor Demo in C#

This project is a **simple C# console application** that demonstrates how to use **deconstructors** (deconstructing methods) to break down structured sensor data into individual values. It simulates a scenario in an **IoT (Internet of Things)** environment where sensor readings like temperature, humidity, and pressure are received and deconstructed for further processing.

---

## 📌 Features

- ✅ Simulated IoT Sensor Data (Temperature, Humidity, Pressure)
- ✅ Deconstructors (`Deconstruct` method) for tuple-style unpacking
- ✅ Supports:
  - Full deconstruction
  - Partial deconstruction
  - Discarding unused values with `_`
  - Assignment to existing variables

---

## 📚 What is a Deconstructor?

A **deconstructor** in C# is a method called `Deconstruct` with one or more `out` parameters that allows tuple-style unpacking of object properties into variables.

```csharp
public void Deconstruct(out double temp, out double hum)
{
    temp = Temperature;
    hum = Humidity;
}
```

````

This allows you to write:

```csharp
var (temperature, humidity) = reading;
```

---

## 🌐 IoT Use Case

In a real IoT environment, devices like sensors (e.g., DHT11, BME280, etc.) regularly send structured data (temperature, humidity, pressure). Instead of accessing each property individually, deconstructors let you cleanly unpack this data:

```csharp
SensorReading reading = GetSensorReading();
var (temp, hum, press) = reading;
```

This makes the code more **readable**, **maintainable**, and **efficient**.

---

## 💡 Sample Output

```bash
[Full] Temp: 22.3°C, Humidity: 55.8%, Pressure: 1012.5 hPa
[Partial] Temp: 22.3°C, Humidity: 55.8%
[Humidity only] Humidity: 55.8%
[Assignment] Temp: 22.3°C, Humidity: 55.8%, Pressure: 1012.5 hPa
```

## 📦 Example Code

### SensorReading.cs

```csharp
class SensorReading
{
    public double Temperature { get; }
    public double Humidity { get; }
    public double Pressure { get; }

    public SensorReading(double temperature, double humidity, double pressure) =>
        (Temperature, Humidity, Pressure) = (temperature, humidity, pressure);

    public void Deconstruct(out double temperature, out double humidity, out double pressure) =>
        (temperature, humidity, pressure) = (Temperature, Humidity, Pressure);

    public void Deconstruct(out double temperature, out double humidity) =>
        (temperature, humidity) = (Temperature, Humidity);
}
```

---

## 🛠️ Future Enhancements (Optional)

- ✅ Simulate live data using `Random` or timers
- ✅ Connect to a real sensor via SerialPort or GPIO
- ✅ Use MQTT or REST to transmit readings
- ✅ Add logging or persistence (file or DB)

---

## 🤝 Contributing

Feel free to fork this project and enhance it for real-world IoT integration. Contributions welcome!

---

## 📝 License

This project is licensed under the [MIT License](LICENSE).

````
