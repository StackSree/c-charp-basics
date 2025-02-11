Here’s the rephrased `README.md` file:  

---

# Demonstrating OOP with **IoT System Control using IP Camera, Light Sensor, and Temperature Sensor**

## Overview  

This project demonstrates **Object-Oriented Programming (OOP)** principles by simulating an **IoT-based smart home control system**. The system includes a **Temperature Sensor, Light Sensor, Smart Light, and an IP Camera**, all interacting dynamically based on environmental conditions.  

### Features  
- **SmartDevice Base Class**: Defines common properties and behavior for all IoT devices.  
- **Temperature Sensor**: Monitors temperature and triggers actions when thresholds are exceeded.  
- **Light Sensor**: Detects ambient light levels and controls the smart light accordingly.  
- **Smart Light**: Changes color or brightness based on sensor input.  
- **IP Camera**: Streams and records video when specific conditions are met.  
- **OOP Implementation**: Uses **Encapsulation, Abstraction, Inheritance, and Polymorphism** to design an efficient and modular system.  

## Project Structure  

```bash  
├── SmartDevice.cs           # Base class for all devices  
├── TemperatureSensor.cs     # Monitors temperature changes  
├── LightSensor.cs           # Detects ambient light levels  
├── SmartLight.cs            # Adjusts brightness or color based on sensor input  
├── IPCamera.cs              # Streams and records video  
└── Program.cs               # Main program simulating IoT behavior  
```  

## Requirements  

- .NET Core SDK (or .NET Framework)  
- C# development environment (e.g., Visual Studio, Visual Studio Code)  

## How to Run  

1. **Clone the Repository**  

   ```bash  
   git clone https://github.com/StackSree/c-charp-basics/OOPWithIOTDeviceSample.git  
   ```  

2. **Open the Project**  

   Open the project folder in your preferred C# IDE.  

3. **Run the Program**  

   Press `F5` or execute the following command in the terminal:  

   ```bash  
   dotnet run  
   ```  

## Example Output  

```
Temperature Sensor is now ON.  
Light Sensor is now ON.  
Smart Light is now ON.  
IP Camera is now ON.  
Temperature Sensor reads 22.5°C.  
Light Sensor detects Bright Environment.  
Smart Light remains White.  
IP Camera is set to 1080p resolution. Recording: OFF.  

Temperature Sensor updated to 28°C.  
Light Sensor detects Dim Environment.  
Smart Light changes to Warm Yellow.  
IP Camera starts streaming video in 1080p resolution.  
IP Camera recording is now ON.  
```  

## IoT System Behavior  

1. **Temperature Sensor**: Detects room temperature and triggers actions when exceeding a set threshold.  
2. **Light Sensor**: Adjusts smart lighting based on brightness levels in the environment.  
3. **Smart Light**: Changes brightness or color dynamically in response to sensor inputs.  
4. **IP Camera**: Activates video streaming and recording based on temperature or light conditions.  

## OOP Concepts Applied  

### 1. **Encapsulation**  
- Each device encapsulates its internal properties and behavior while exposing controlled interactions.  

### 2. **Abstraction**  
- The `SmartDevice` base class defines a high-level interface for IoT devices while hiding implementation details.  

### 3. **Inheritance**  
- `TemperatureSensor`, `LightSensor`, `SmartLight`, and `IPCamera` inherit common functionality from `SmartDevice`.  

### 4. **Polymorphism**  
- Devices override the `DeviceStatus()` method to provide unique behavior while maintaining a consistent interface.  

## Future Enhancements  

- **Real IoT Integration**: Connect to physical IoT sensors and cameras via **MQTT, HTTP APIs, or WebSockets**.  
- **Cloud Connectivity**: Enable remote monitoring using **Azure IoT Hub or AWS IoT Core**.  
- **Advanced AI Processing**: Implement **computer vision** for motion detection in the IP Camera.  

## License  

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.  

## Acknowledgements  

- **IoT Concepts**: Simulating real-world IoT interactions using OOP principles.  
- **.NET Core**: Enabling cross-platform compatibility and performance efficiency.  

---

This **README.md** serves as a structured guide to the IoT system, highlighting its functionality, implementation details, and future improvements. Let me know if you need further refinements! 🚀
