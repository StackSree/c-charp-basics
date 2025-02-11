namespace OOPWithIOTDeviceSample;

internal class Program
{
    protected Program()
    {
    }

    static void Main(string[] args)
    {
        // Create devices
        SmartDevice tempSensor = new TemperatureSensor("Living Room Temp Sensor", 22.5);
        SmartDevice light = new SmartLight("Living Room Light", "White");
        SmartDevice ipCamera = new IPCamera("Front Door IP Camera", "1080p");

        // Turn on devices
        tempSensor.TurnOn();
        light.TurnOn();
        ipCamera.TurnOn();

        // Check initial device status
        tempSensor.DeviceStatus();
        light.DeviceStatus();
        ipCamera.DeviceStatus();

        // Simulating temperature change
        TemperatureSensor actualTempSensor = (TemperatureSensor)tempSensor;
        actualTempSensor.SetTemperature(28); // Update temperature

        // If temperature exceeds 25°C, change light color to Red, and start video recording with IP Camera
        if (actualTempSensor.IsOn && actualTempSensor.temperature > 25)
        {
            SmartLight actualLight = (SmartLight)light;
            actualLight.SetColor("Red");

            IPCamera actualCamera = (IPCamera)ipCamera;
            actualCamera.StartStreaming();  // Start video streaming
            actualCamera.ToggleRecording(); // Start recording
        }

        // Final device status after action
        tempSensor.DeviceStatus();
        light.DeviceStatus();
        ipCamera.DeviceStatus();
    }
}

