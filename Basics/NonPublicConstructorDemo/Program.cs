namespace NonPublicConstructorDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- IoT Sensor Data Manager Demo (Singleton) ---");

        // Attempting to directly instantiate SensorDataManager will result in a compile-time error:
        // SensorDataManager myManager = new SensorDataManager(); // Error: 'SensorDataManager.SensorDataManager()' is inaccessible

        Console.WriteLine("Attempting to get the first SensorDataManager instance...");
        SensorDataManager manager1 = SensorDataManager.GetInstance();
        manager1.CollectSensorData("TempSensor001", 23.5, "°C");
        manager1.CollectSensorData("HumSensor002", 60.2, "%RH");

        Console.WriteLine("\nAttempting to get the second SensorDataManager instance...");
        SensorDataManager manager2 = SensorDataManager.GetInstance();
        manager2.CollectSensorData("TempSensor001", 23.7, "°C"); // Note: Same sensor ID, different reading
        manager2.CollectSensorData("LightSensor003", 500, "lux"); // New sensor

        // Verify that manager1 and manager2 refer to the same instance
        Console.WriteLine($"\nAre manager1 and manager2 the same instance? {ReferenceEquals(manager1, manager2)}");

        // Process all collected data
        manager1.ProcessAllSensorData(); // Or manager2.ProcessAllSensorData(), as they are the same instance

        Console.WriteLine("\n--- IoT Device Configuration Factory Demo (Factory Method) ---");

        try
        {
            IotDevice tempSensor = DeviceFactory.CreateDevice("TemperatureSensor", "THS-ROOM-001");
            tempSensor.Connect();
            tempSensor.SendTelemetry("{\"temp\": 25.1}");

            IotDevice humSensor = DeviceFactory.CreateDevice("HumiditySensor", "HUM-LAB-002");
            humSensor.Connect();
            humSensor.SendTelemetry("{\"humidity\": 55.8}");

            IotDevice unknownDevice = DeviceFactory.CreateDevice("PressureSensor", "PRS-OUT-003"); // This will throw an exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError creating device: {ex.Message}");
        }
    }
}

public class SensorDataManager
{
    private static SensorDataManager _instance;
    private readonly List<string> _sensorReadings;
    private static readonly object _lock = new object(); // For thread safety
    private bool _isInitialized;

    // Private constructor: Prevents direct instantiation from outside
    private SensorDataManager()
    {
        _sensorReadings = new List<string>();
        _isInitialized = false;
        Console.WriteLine("[SensorDataManager] Instance created (private constructor called).");
    }

    // Public static method to control instance creation (Singleton access)
    public static SensorDataManager GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock) // Ensure thread safety during instance creation
            {
                if (_instance == null)
                {
                    _instance = new SensorDataManager();
                    // Perform any one-time initialization here
                    _instance.Initialize();
                }
            }
        }
        return _instance;
    }

    // Optional: Private initialization method, called once by GetInstance
    private void Initialize()
    {
        if (!_isInitialized)
        {
            Console.WriteLine("[SensorDataManager] Initializing sensor data processing system...");
            // Simulate connecting to a database, cloud service, or initializing hardware interfaces
            Thread.Sleep(500); // Simulate some initialization work
            _isInitialized = true;
            Console.WriteLine("[SensorDataManager] Initialization complete.");
        }
    }

    public void CollectSensorData(string sensorId, double value, string unit)
    {
        if (!_isInitialized)
        {
            Console.WriteLine($"[SensorDataManager] Warning: Not initialized yet. Skipping data collection for {sensorId}.");
            return;
        }

        string reading = $"{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}Z - Sensor '{sensorId}': {value}{unit}";
        lock (_sensorReadings) // Protect list access in multithreaded environment
        {
            _sensorReadings.Add(reading);
        }
        Console.WriteLine($"[SensorDataManager] Collected: {reading}");
        // In a real IoT scenario, you might also push this data to a queue or a cloud service here.
    }

    public void ProcessAllSensorData()
    {
        if (!_isInitialized)
        {
            Console.WriteLine("[SensorDataManager] Cannot process data: System not initialized.");
            return;
        }

        Console.WriteLine("\n--- Processing All Sensor Readings ---");
        lock (_sensorReadings)
        {
            if (_sensorReadings.Count == 0)
            {
                Console.WriteLine("No sensor data to process.");
                return;
            }
            foreach (var reading in _sensorReadings)
            {
                Console.WriteLine($"[Processing] {reading}");
                // Simulate data analysis, anomaly detection, or further aggregation
                // Task.Delay(50).Wait(); // Simulate some processing time
            }
            _sensorReadings.Clear(); // Clear processed data (or archive it)
        }
        Console.WriteLine("--- Sensor Data Processing Complete ---\n");
    }
}

// --- IoT Use Case: Device Configuration Factory (Factory Method Pattern) ---

// Base class for different device types
public abstract class IotDevice
{
    public string DeviceId { get; protected set; }
    public string DeviceType { get; protected set; }

    public abstract void Connect();
    public abstract void SendTelemetry(string data);
}

// Concrete Device Type 1: Temperature Sensor
public class TemperatureSensorDevice : IotDevice
{
    // Private constructor: Only the factory can create this
    private TemperatureSensorDevice(string id)
    {
        DeviceId = id;
        DeviceType = "TemperatureSensor";
        Console.WriteLine($"[TemperatureSensorDevice] Created device ID: {id}");
    }

    // Internal static factory method for use by DeviceFactory
    internal static TemperatureSensorDevice Create(string id)
    {
        return new TemperatureSensorDevice(id);
    }

    public override void Connect()
    {
        Console.WriteLine($"[TemperatureSensorDevice] Connecting to MQTT broker for {DeviceId}...");
    }

    public override void SendTelemetry(string data)
    {
        Console.WriteLine($"[TemperatureSensorDevice] Sending temperature telemetry for {DeviceId}: {data}");
    }
}

// Concrete Device Type 2: Humidity Sensor
public class HumiditySensorDevice : IotDevice
{
    // Private constructor: Only the factory can create this
    private HumiditySensorDevice(string id)
    {
        DeviceId = id;
        DeviceType = "HumiditySensor";
        Console.WriteLine($"[HumiditySensorDevice] Created device ID: {id}");
    }

    // Internal static factory method for use by DeviceFactory
    internal static HumiditySensorDevice Create(string id)
    {
        return new HumiditySensorDevice(id);
    }

    public override void Connect()
    {
        Console.WriteLine($"[HumiditySensorDevice] Connecting to cloud platform for {DeviceId}...");
    }

    public override void SendTelemetry(string data)
    {
        Console.WriteLine($"[HumiditySensorDevice] Sending humidity telemetry for {DeviceId}: {data}");
    }
}

// Factory for creating IoT Devices
public static class DeviceFactory
{
    public static IotDevice CreateDevice(string deviceType, string deviceId)
    {
        Console.WriteLine($"\n[DeviceFactory] Creating device of type '{deviceType}' with ID '{deviceId}'...");
        switch (deviceType.ToLower())
        {
            case "temperaturesensor":
                // The factory knows how to call the internal static creation method
                return TemperatureSensorDevice.Create(deviceId);
            case "humiditysensor":
                return HumiditySensorDevice.Create(deviceId);
            // Add more device types here
            default:
                throw new ArgumentException($"Unsupported device type: {deviceType}");
        }
    }
}

