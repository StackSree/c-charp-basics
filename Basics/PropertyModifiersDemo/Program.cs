namespace PropertyModifiersDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Static property access without object
        Console.WriteLine($"Device Type: {Sensor.DeviceType}");

        Sensor sensor = new Sensor();
        sensor.ShowValue(); // Output: Base Value: 25.5

        AdvancedSensor advSensor = new AdvancedSensor();
        advSensor.ShowValue(); // Output: Base Value: 30.5

        Console.WriteLine($"Sensor Name: {advSensor.SensorName}");

        // Attempt to change SensorName (not allowed due to private set)
        // advSensor.SensorName = "Another"; // ❌ Compilation error
    }
}

public class Sensor
{
    // Access modifier: protected
    // Inheritance modifier: virtual
    protected virtual double Value { get; set; } = 25.5;

    // Public static property
    public static string DeviceType { get; set; } = "Temperature Sensor";

    // Public method to read the protected property
    public void ShowValue()
    {
        Console.WriteLine($"Base Value: {Value}");
    }
}

// Derived class overrides Value property
public class AdvancedSensor : Sensor
{
    // Override with different logic
    protected override double Value
    {
        get { return base.Value + 5; }  // Custom logic
        set { base.Value = value - 2; } // Custom logic
    }

    // Public property with private setter
    public string SensorName { get; private set; } = "AdvancedSensorX";
}
