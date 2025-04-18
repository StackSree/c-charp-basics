namespace GridV2;

public class Grid
{
    public string Version { get; } = "Version 2.0 - Advanced Features";
    public void DisplayVersion()
    {
        System.Console.WriteLine($"Grid Control (Version 2): {Version}");
    }
}
