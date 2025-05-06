namespace MethodWithStaticModifierDemo;

internal class Program
{
    static void Main(string[] args)
    {
        double radius = 5.0;

        // Calling the static method directly using the class name
        double area = CircleHelper.CalculateArea(radius);
        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");

        // To call the non-static method, we need to create an instance of the class
        CircleHelper helper = new CircleHelper();
        double circumference = helper.CalculateCircumference(radius);
        Console.WriteLine($"The circumference of the circle with radius {radius} is: {circumference}");
    }
}

public class CircleHelper
{
    // A static method to calculate the area of a circle
    public static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // A non-static method (for comparison)
    public double CalculateCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
}
