using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithIOTDeviceSample;

public abstract class SmartDevice(string deviceName)
{
    private bool isOn = false;

    public string DeviceName => deviceName;
    public bool IsOn => isOn;

    public void TurnOn()
    {
        isOn = true;
        Console.WriteLine($"{deviceName} is now ON.");
    }

    public void TurnOff()
    {
        isOn = false;
        Console.WriteLine($"{deviceName} is now OFF.");
    }

    public abstract void DeviceStatus();
}
