using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithIOTDeviceSample;

public class IPCamera(string deviceName, string resolution) : SmartDevice(deviceName)
{
    private readonly string resolution = resolution;
    private bool isRecording = false;

    // Overriding the DeviceStatus method (Polymorphism)
    public override void DeviceStatus()
    {
        Console.WriteLine($"{DeviceName} is set to {resolution} resolution. Recording: {(isRecording ? "ON" : "OFF")}");
    }

    // Method to simulate video streaming
    public void StartStreaming()
    {
        if (IsOn)
        {
            Console.WriteLine($"{DeviceName} is now streaming video in {resolution} resolution.");
        }
        else
        {
            Console.WriteLine($"{DeviceName} is OFF. Please turn on the camera first.");
        }
    }

    // Method to start/stop video recording
    public void ToggleRecording()
    {
        if (IsOn)
        {
            isRecording = !isRecording;
            Console.WriteLine($"{DeviceName} recording is now {(isRecording ? "ON" : "OFF")}");
        }
        else
        {
            Console.WriteLine($"{DeviceName} is OFF. Please turn on the camera first.");
        }
    }
}
