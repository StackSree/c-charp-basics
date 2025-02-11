using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithIOTDeviceSample;

public class TemperatureSensor(string deviceName, double initialTemperature) : SmartDevice(deviceName)
{
    public double temperature = initialTemperature;

    // Overriding the DeviceStatus method (Polymorphism)
    public override void DeviceStatus()
    {
        Console.WriteLine($"{DeviceName} is reading a temperature of {temperature}°C.");
    }

    // Method to simulate temperature change
    public void SetTemperature(double newTemperature)
    {
        temperature = newTemperature;
        Console.WriteLine($"{DeviceName} temperature updated to {temperature}°C.");
    }
}
