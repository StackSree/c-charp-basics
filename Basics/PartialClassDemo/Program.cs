namespace PartialClassDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Phone = "123-456-7890"
        };

        Console.WriteLine($"Full Name: {customer.GetFullName()}"); // Output: Full Name: John Doe
        customer.PrintContactInfo(); // Output: Email: john.doe@example.com, Phone: 123-456-7890
    }
}
public partial class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}

public partial class Customer
{
    public string Email { get; set; }
    public string Phone { get; set; }

    public void PrintContactInfo()
    {
        Console.WriteLine($"Email: {Email}, Phone: {Phone}");
    }
}
