
namespace UtilitiesNamespacesDemo;

public class StringHelper
{

    public string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

}
