namespace VolatileDemo;

internal class Program
{

    private static bool _isReadyNonVolatile = false;
    private static volatile bool _isReadyVolatile = false;
    private static int _valueNonVolatile = 0;
    private static volatile int _valueVolatile = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating non-volatile field:");
        Thread nonVolatileWriter = new Thread(NonVolatileWriter);
        Thread nonVolatileReader = new Thread(NonVolatileReader);

        nonVolatileReader.Start();
        nonVolatileWriter.Start();

        Thread.Sleep(100); // Give some time for execution

        _isReadyNonVolatile = true;
        _valueNonVolatile = 10;
        Console.WriteLine("Non-volatile writer finished.");

        nonVolatileWriter.Join();
        nonVolatileReader.Join();

        Console.WriteLine("\nDemonstrating volatile field:");
        Thread volatileWriter = new Thread(VolatileWriter);
        Thread volatileReader = new Thread(VolatileReader);

        volatileReader.Start();
        volatileWriter.Start();

        Thread.Sleep(100); // Give some time for execution

        _isReadyVolatile = true;
        _valueVolatile = 20;
        Console.WriteLine("Volatile writer finished.");

        volatileWriter.Join();
        volatileReader.Join();
    }

    static void NonVolatileWriter()
    {
        Console.WriteLine("Non-volatile writer started.");
        Thread.Sleep(50); // Introduce a small delay
    }

    static void NonVolatileReader()
    {
        Console.WriteLine("Non-volatile reader started.");
        while (!_isReadyNonVolatile)
        {
            // Spinning while waiting
        }
        Console.WriteLine($"Non-volatile reader: _isReadyNonVolatile is now {_isReadyNonVolatile}, _valueNonVolatile is {_valueNonVolatile}");
    }

    static void VolatileWriter()
    {
        Console.WriteLine("Volatile writer started.");
        Thread.Sleep(50); // Introduce a small delay
    }

    static void VolatileReader()
    {
        Console.WriteLine("Volatile reader started.");
        while (!_isReadyVolatile)
        {
            // Spinning while waiting
        }
        Console.WriteLine($"Volatile reader: _isReadyVolatile is now {_isReadyVolatile}, _valueVolatile is {_valueVolatile}");
    }
}

