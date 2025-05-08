namespace MethodWithInheritanceModifiers;

using System;
using System.Threading;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- IoT Sensor Inheritance Modifiers Demo ---");

        BaseSensor sensor = new AdvancedSensor();  // uses override
        CentralHub hub = new CentralHub(sensor);
        Thread monitoringThread = new Thread(hub.MonitorTemperature);
        monitoringThread.Start();

        Console.WriteLine("Monitoring... Press any key to stop.");
        Console.ReadKey();
    }
}

// ======== ABSTRACT + VIRTUAL ========

// Abstract class enforces GetTemperature() implementation
public abstract class BaseSensor
{
    public abstract int GetTemperature();
}

// Virtual method that can be overridden
public class TemperatureSensor : BaseSensor
{
    protected Random random = new Random();

    public override int GetTemperature()
    {
        int temp = random.Next(15, 31);
        Console.WriteLine($"[TemperatureSensor] Raw Temp: {temp}");
        return temp;
    }
}

// ======== OVERRIDE + SEALED ========

public class AdvancedSensor : TemperatureSensor
{
    // Override and seal: can't override this further
    public sealed override int GetTemperature()
    {
        int temp = base.GetTemperature() + 1; // simulate adjustment
        Console.WriteLine($"[AdvancedSensor] Calibrated Temp: {temp}");
        return temp;
    }
}

// ======== NEW (Method Hiding) ========

public class FakeSensor : TemperatureSensor
{
    // Hides the base GetTemperature (not a true override)
    public new int GetTemperature()
    {
        Console.WriteLine("[FakeSensor] Fake Temp: 99");
        return 99;
    }
}

// ======== MONITORING LOGIC ========

public class CentralHub
{
    private BaseSensor sensor;
    private const int Threshold = 25;

    public CentralHub(BaseSensor sensor)
    {
        this.sensor = sensor;
    }

    public void MonitorTemperature()
    {
        while (true)
        {
            int temp = sensor.GetTemperature();
            Console.WriteLine($"[CentralHub] Current Temp: {temp}°C");

            if (temp > Threshold)
            {
                TriggerAlert(temp);
            }

            Thread.Sleep(2000);
        }
    }

    private void TriggerAlert(int temp)
    {
        Console.WriteLine($"\n** ALERT! Temp exceeded {Threshold}°C — Current: {temp}°C **\n");
    }
}
