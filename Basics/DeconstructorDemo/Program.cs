namespace DeconstructorDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Simulate getting a reading from an IoT sensor
        SensorReading reading = new SensorReading(22.3, 55.8, 1012.5);

        // Full deconstruction
        var (temp, hum, press) = reading;
        Console.WriteLine($"[Full] Temp: {temp}°C, Humidity: {hum}%, Pressure: {press} hPa");

        // Partial deconstruction
        var (temp2, hum2) = reading;
        Console.WriteLine($"[Partial] Temp: {temp2}°C, Humidity: {hum2}%");

        // Using discard (_) to ignore values
        var (_, humOnly, _) = reading;
        Console.WriteLine($"[Humidity only] Humidity: {humOnly}%");

        // Deconstruction assignment to existing variables
        double t, h, p;
        (t, h, p) = reading;
        Console.WriteLine($"[Assignment] Temp: {t}°C, Humidity: {h}%, Pressure: {p} hPa");

        Console.ReadLine(); // Keep console window open
    }
}
// Simulated sensor data class
class SensorReading
{
    public double Temperature { get; }
    public double Humidity { get; }
    public double Pressure { get; }

    public SensorReading(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
    }

    // Deconstructor method
    public void Deconstruct(out double temperature, out double humidity, out double pressure)
    {
        temperature = Temperature;
        humidity = Humidity;
        pressure = Pressure;
    }

    // Optional: Overload to ignore pressure
    public void Deconstruct(out double temperature, out double humidity)
    {
        temperature = Temperature;
        humidity = Humidity;
    }
}
