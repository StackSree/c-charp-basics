namespace MethodWithInheritanceModifiers;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Simple IoT Temperature Monitoring Demo ---");

        // Initialize the simulated sensor and hub
        TemperatureSensor sensor = new TemperatureSensor();
        CentralHub hub = new CentralHub(sensor);

        // Start monitoring in a new thread to keep the main thread alive
        Thread monitoringThread = new Thread(hub.MonitorTemperature);
        monitoringThread.Start();

        // Keep the main thread running (you might have other interactions here in a real app)
        Console.WriteLine("Monitoring temperature... Press any key to exit.");
        Console.ReadKey();

        // Optionally, you could signal the monitoring thread to stop gracefully
        // monitoringThread.Abort(); // Not recommended for clean shutdown in real apps
    }
}

// 1. Simulated Temperature Sensor
public class TemperatureSensor
{
    private Random random = new Random();

    public int GetTemperature()
    {
        // Simulate reading a temperature value (e.g., between 15 and 30 degrees Celsius)
        return random.Next(15, 31);
    }
}

// 2. Simulated Central Hub
public class CentralHub
{
    private TemperatureSensor sensor;
    private const int TemperatureThreshold = 25;

    public CentralHub(TemperatureSensor sensor)
    {
        this.sensor = sensor;
    }

    public void MonitorTemperature()
    {
        while (true)
        {
            int currentTemperature = sensor.GetTemperature();
            Console.WriteLine($"Current Temperature: {currentTemperature}°C");

            if (currentTemperature > TemperatureThreshold)
            {
                TriggerAlert(currentTemperature);
            }

            // Simulate reading data every 2 seconds
            Thread.Sleep(2000);
        }
    }

    private void TriggerAlert(int temperature)
    {
        Console.WriteLine($"\n**ALERT! Temperature exceeded threshold ({TemperatureThreshold}°C). Current temperature: {temperature}°C **\n");
        // In a real system, this could send an email, SMS, or trigger a notification.
    }
}
