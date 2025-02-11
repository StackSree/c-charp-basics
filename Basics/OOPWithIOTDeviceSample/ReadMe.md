**IoT System with IP Camera and Video Streaming**

---

# IoT System with IP Camera and Video Streaming

## Overview

This project simulates a **smart home IoT system** that includes various smart devices, such as a **Temperature Sensor**, **Smart Light**, and an **IP Camera** capable of video streaming and recording.
 Using **Object-Oriented Programming (OOP)** in C#, we demonstrate the integration of these devices in a system where they interact based on environmental conditions (e.g., temperature changes).

### Features
- **SmartDevice Class**: Base class for all devices with common functionalities like turning on/off.
- **Temperature Sensor**: Simulates a temperature sensor with the ability to change the temperature and report its status.
- **Smart Light**: A smart light that changes color based on conditions like temperature.
- **IP Camera**: Simulates an IP camera with video streaming and recording features that are triggered by certain conditions.
- **OOP Principles**: The system uses **Encapsulation**, **Abstraction**, **Inheritance**, and **Polymorphism**.

## Project Structure

```bash
├── SmartDevice.cs           # Base class for all devices
├── TemperatureSensor.cs     # Temperature sensor device
├── SmartLight.cs            # Smart light device
├── IPCamera.cs              # IP Camera device with streaming and recording
└── Program.cs               # Main program to simulate IoT behavior
```

## Requirements

- .NET Core SDK (or .NET Framework)
- C# development environment (e.g., Visual Studio, Visual Studio Code)

## How to Run

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/iot-smart-home.git
   ```

2. **Open the Project**

   Open the project folder in your favorite C# IDE (e.g., Visual Studio or Visual Studio Code).

3. **Run the Program**

   Press `F5` or use the terminal to run the project:

   ```bash
   dotnet run
   ```

## Example Output

When the program runs, you will see output similar to this:

```
Living Room Temp Sensor is now ON.
Living Room Light is now ON.
Front Door IP Camera is now ON.
Living Room Temp Sensor is reading a temperature of 22.5°C.
Living Room Light is White.
Front Door IP Camera is set to 1080p resolution. Recording: OFF
Living Room Temp Sensor temperature updated to 28°C.
Living Room Light color changed to Red.
Front Door IP Camera is now streaming video in 1080p resolution.
Front Door IP Camera recording is now ON
Living Room Temp Sensor is reading a temperature of 28°C.
Living Room Light is Red.
Front Door IP Camera is set to 1080p resolution. Recording: ON
```

## IoT System Behavior

1. **Temperature Sensor**: Starts with a default temperature. When the temperature rises above a certain threshold (e.g., 25°C), it triggers other devices in the system to respond.

2. **Smart Light**: Changes color based on the temperature detected by the sensor. For instance, if the temperature exceeds a set limit (25°C), the light changes to **Red**.

3. **IP Camera**: Starts streaming and recording when the temperature rises above the threshold. The camera simulates the process of recording a video in **1080p** resolution.

## Concepts Demonstrated

### 1. **Encapsulation**  
Encapsulating the details of each device inside its class. For example, device status (on/off), temperature, or light color are hidden and accessed via methods or properties.

### 2. **Abstraction**  
Providing a simplified interface for devices while hiding implementation details. Devices like the `IP Camera` or `TemperatureSensor` expose high-level functionality, like turning on/off or changing status, without showing the underlying logic.

### 3. **Inheritance**  
The base class `SmartDevice` is inherited by the specific devices like `TemperatureSensor`, `SmartLight`, and `IPCamera`. This allows code reuse and keeps the structure organized.

### 4. **Polymorphism**  
Each derived class overrides the `DeviceStatus()` method, which provides different outputs for each device, while still using the same method name in the base class.

## Future Enhancements

1. **Integration with real IoT devices**: Implementing actual IoT hardware (sensors, cameras) using C# libraries like **HttpClient** to interact with APIs of real-world IoT devices.
2. **Real Video Streaming**: Integrate real video streaming capabilities with libraries like **OpenCV** or **FFmpeg** for actual video capture and streaming.
3. **Cloud Integration**: Connect the system to cloud services like **Azure IoT Hub** or **AWS IoT** to manage and monitor the devices remotely.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- **IoT Concepts**: The foundation of the project is based on IoT device interactions and how OOP concepts can be applied in the domain of IoT systems.
- **.NET Core**: Leveraging .NET Core to build the system for cross-platform compatibility.

---

This **README.md** gives a comprehensive explanation of the IoT System with IP Camera and Video Streaming simulation. It includes details on how to set up and run the system, along with key features and OOP concepts used. You can customize this template to suit your specific project needs.