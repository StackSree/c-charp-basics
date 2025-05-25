namespace ObjectInitializweDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Using parameterless constructor + object initializer
        SensorReading reading1 = new SensorReading
        {
            DeviceId = "DHT11-A1",
            Temperature = 28.5,
            Humidity = 60.2,
            IsCritical = false
        };

        // Using constructor + object initializer
        SensorReading reading2 = new SensorReading("DHT11-B7")
        {
            Temperature = 45.1,
            Humidity = 80.5,
            IsCritical = true
        };

        // Display the readings
        reading1.PrintStatus();
        reading2.PrintStatus();
    }
}

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
