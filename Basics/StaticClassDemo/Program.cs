namespace StaticClassDemo;

internal class Program
{
    static void Main(string[] args)
    {
        string original = "hello";
        string reversed = StringHelper.ReverseString(original);
        Console.WriteLine($"Original: {original}, Reversed: {reversed}"); // Output: Original: hello, Reversed: olleh

        string palindrome = "racecar";
        bool isPal = StringHelper.IsPalindrome(palindrome);
        Console.WriteLine($"'{palindrome}' is a palindrome: {isPal}"); // Output: 'racecar' is a palindrome: True
    }
}

public static class StringHelper
{
    public static string ReverseString(string input)
    {
        if (input == null)
        {
            return null;
        }
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static bool IsPalindrome(string input)
    {
        if (input == null)
        {
            return false;
        }
        string reversed = ReverseString(input);
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}

