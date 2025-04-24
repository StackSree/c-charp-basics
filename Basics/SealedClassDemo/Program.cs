namespace SealedClassDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the sealed class
        ConfigurationSettings appConfig = new("localhost", "/var/log/app.log");

        // Access and use the members of the sealed class
        appConfig.DisplaySettings();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
sealed class ConfigurationSettings
{
    public string DatabaseServer { get; }
    public string LogFilePath { get; }

    public ConfigurationSettings(string databaseServer, string logFilePath)
    {
        DatabaseServer = databaseServer;
        LogFilePath = logFilePath;
    }

    public void DisplaySettings()
    {
        Console.WriteLine($"Database Server: {DatabaseServer}");
        Console.WriteLine($"Log File Path: {LogFilePath}");
    }
}
