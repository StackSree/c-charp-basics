namespace ConstantsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Application Version (const): {AppSettings.Version}");
        Console.WriteLine($"Application Build Date (static readonly): {AppSettings.BuildDate}");
        Console.WriteLine($"Default Admin Roles (static readonly): {string.Join(", ", AppSettings.DefaultAdminRoles)}");

        // You cannot reassign a const field:
        // AppSettings.Version = "1.0.1"; // This would cause a compile-time error

        // You cannot reassign a static readonly field directly:
        // AppSettings.BuildDate = DateTime.MinValue; // This would cause a compile-time error

        // However, for reference types (like List<string>), you can modify their internal state:
        AppSettings.DefaultAdminRoles.Add("SystemAdmin");
        Console.WriteLine($"Default Admin Roles After Modification: {string.Join(", ", AppSettings.DefaultAdminRoles)}");
    }
}

public class AppSettings
{
    // A compile-time constant for the application's version
    public const string Version = "1.0.0";

    // A runtime constant (initialized when the class is loaded)
    public static readonly DateTime BuildDate;

    // Another runtime constant, initialized with a list
    public static readonly List<string> DefaultAdminRoles;

    // Static constructor to initialize static readonly fields
    static AppSettings()
    {
        BuildDate = DateTime.Now; // Current date and time when the class is loaded
        DefaultAdminRoles = new List<string> { "Admin", "SuperAdmin" };
    }
}
