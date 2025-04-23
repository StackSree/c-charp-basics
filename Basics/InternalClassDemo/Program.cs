namespace InternalClassDemo;

public class Program
{
    static void Main(string[] args)
    {
        var controller = new IoTDeviceController();
        controller.AddTemperatureSensor("TempSensor01", "0xA1");
        controller.AddTemperatureSensor("TempSensor02", "0xB5");

        controller.ReadAndDisplayTemperatures();

        controller.CalibrateAllSensors(0.5);

        // You cannot directly access the internal class from outside its assembly.
        // The following line would cause a compile-time error:
        // SensorProtocolHandler handler = new SensorProtocolHandler();

        Console.WriteLine("\nDemo finished. Press any key to exit.");
        Console.ReadKey();
    }
}

// Simulate low-level communication with a specific sensor type
internal class SensorProtocolHandler
{
    private readonly string _protocolVersion = "v1.0";

    internal string ReadRawData(string sensorAddress)
    {
        // Simulate sending a command and receiving a response
        Console.WriteLine($"[Protocol Handler] Sending read command to sensor at {sensorAddress} (Protocol {_protocolVersion})...");
        // Simulate receiving raw bytes
        byte[] rawBytes = new byte[8];
        new Random().NextBytes(rawBytes);
        return BitConverter.ToString(rawBytes).Replace("-", ""); // Return as a hex string
    }

    internal void SendCommand(string sensorAddress, string commandCode)
    {
        Console.WriteLine($"[Protocol Handler] Sending command '{commandCode}' to sensor at {sensorAddress} (Protocol {_protocolVersion})...");
        // Simulate sending the command
    }
}

public class TemperatureSensor
{
    private readonly string _sensorId;
    private readonly string _address;
    private readonly SensorProtocolHandler _protocolHandler; // Using the internal class

    public TemperatureSensor(string sensorId, string address)
    {
        _sensorId = sensorId;
        _address = address;
        _protocolHandler = new SensorProtocolHandler();
        Console.WriteLine($"Temperature Sensor '{_sensorId}' initialized at address '{_address}'.");
    }

    public double GetCurrentTemperature()
    {
        string rawData = _protocolHandler.ReadRawData(_address);
        // Simulate parsing the raw data to get temperature (very basic example)
        if (rawData.Length >= 4)
        {
            int rawValue = Convert.ToInt16(rawData.Substring(0, 4), 16);
            // Simple scaling - real implementation would be more complex
            return (double)rawValue / 10.0;
        }
        return double.NaN; // Indicate failure to read
    }

    public void CalibrateSensor(double offset)
    {
        // In a real scenario, this might involve sending specific commands
        _protocolHandler.SendCommand(_address, $"CALIBRATE:{offset}");
        Console.WriteLine($"Temperature Sensor '{_sensorId}' at '{_address}' calibration command sent with offset '{offset}'.");
    }

    public string GetSensorId() => _sensorId;
}

public class IoTDeviceController
{
    private readonly List<TemperatureSensor> _temperatureSensors = new List<TemperatureSensor>();

    public void AddTemperatureSensor(string sensorId, string address)
    {
        _temperatureSensors.Add(new TemperatureSensor(sensorId, address));
    }

    public void ReadAndDisplayTemperatures()
    {
        Console.WriteLine("\n--- Current Temperatures ---");
        foreach (var sensor in _temperatureSensors)
        {
            double temperature = sensor.GetCurrentTemperature();
            if (!double.IsNaN(temperature))
            {
                Console.WriteLine($"Sensor '{sensor.GetSensorId()}': {temperature}°C");
            }
            else
            {
                Console.WriteLine($"Sensor '{sensor.GetSensorId()}': Error reading temperature.");
            }
        }
    }

    public void CalibrateAllSensors(double commonOffset)
    {
        Console.WriteLine($"\n--- Calibrating All Temperature Sensors with offset {commonOffset}°C ---");
        foreach (var sensor in _temperatureSensors)
        {
            sensor.CalibrateSensor(commonOffset);
        }
    }
}