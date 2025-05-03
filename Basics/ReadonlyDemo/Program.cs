namespace ReadonlyDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Configuration config1 = new Configuration("server1.example.com", 10);
        Console.WriteLine($"Config 1 - Server: {config1.DatabaseServer}, Max Connections: {config1.MaxConnections}, Initialized: {config1.InitializationTime}");
        config1.AddUser("User1");
        Console.WriteLine($"Config 1 - Allowed Users: {string.Join(", ", config1.AllowedUsers)}");

        Configuration config2 = new Configuration("server2.example.net", 20);
        Console.WriteLine($"Config 2 - Server: {config2.DatabaseServer}, Max Connections: {config2.MaxConnections}, Initialized: {config2.InitializationTime}");
        Console.WriteLine($"Config 2 - Allowed Users: {string.Join(", ", config2.AllowedUsers)}");

        // The following lines would cause compile-time errors:
        // config1.DatabaseServer = "new.server.com";
        // config1.MaxConnections = 15;
        // config1.InitializationTime = DateTime.MinValue;
        // config1.AllowedUsers = new List<string>(); // Cannot reassign the list

        Console.ReadKey();
    }
}
public class Configuration
{
    public readonly string DatabaseServer;
    public readonly int MaxConnections;
    public readonly DateTime InitializationTime;
    public readonly List<string> AllowedUsers; // Reference type

    public Configuration(string server, int connections)
    {
        DatabaseServer = server;
        MaxConnections = connections;
        InitializationTime = DateTime.Now;
        AllowedUsers = new List<string>();
        AllowedUsers.Add("Admin");
    }

    public void AddUser(string user)
    {
        AllowedUsers.Add(user); // Modifying the state of the referenced object is allowed
    }
}