namespace GridV1;

public class Grid
{
    public string Version { get; } = "Version 1.0";
    public void DisplayVersion()
    {
        System.Console.WriteLine($"Grid Control (Version 1): {Version}");
    }

}
