using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithIOTDeviceSample;

public class SmartLight(string deviceName, string initialColor) : SmartDevice(deviceName)
{

    // Overriding the DeviceStatus method (Polymorphism)
    public override void DeviceStatus()
    {
        Console.WriteLine($"{DeviceName} is {initialColor}.");
    }

    // Method to change the color of the light
    public void SetColor(string newColor)
    {
        initialColor = newColor;
        Console.WriteLine($"{DeviceName} color changed to {initialColor}.");
    }
}
