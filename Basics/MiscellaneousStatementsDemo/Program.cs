using System.Diagnostics.Metrics;

namespace MiscellaneousStatementsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating the 'using' statement with IDisposable:");
        string filePath = "demo.txt";
        // The 'using' statement ensures that the ResourceHolder object's Dispose()
        // method is called when the block finishes, even if an exception occurs.
        using (ResourceHolder holder = new ResourceHolder(filePath))
        {
            if (holder != null)
            {
                holder.WriteData("This is some data.");
                holder.WriteData("More data here.");
            }
        }
        Console.WriteLine("ResourceHolder has been disposed (implicitly by the 'using' statement).");
        Console.WriteLine();

        Console.WriteLine("Demonstrating the 'lock' statement for thread synchronization:");
        Counter counter = new Counter();

        // Create and start multiple threads that increment the counter
        Thread thread1 = new Thread(counter.Increment);
        Thread thread2 = new Thread(counter.Increment);
        Thread thread3 = new Thread(counter.Increment);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Wait for all threads to complete
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine($"Final counter value: {counter.GetCount()}");
        Console.WriteLine();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

public class Counter
{
    private int _count = 0;
    private object _lockObject = new object();

    public void Increment()
    {
        // Using the lock statement to ensure thread-safe access
        lock (_lockObject)
        {
            _count++;
            Console.WriteLine($"Counter incremented to {_count} by thread {Thread.CurrentThread.ManagedThreadId}.");
        }
    }

    public int GetCount()
    {
        lock (_lockObject)
        {
            return _count;
        }
    }
}

// Example class that implements IDisposable
public class ResourceHolder : IDisposable
{
    private FileStream _fileStream;
    private bool _disposed = false;

    public ResourceHolder(string filePath)
    {
        try
        {
            _fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Console.WriteLine("ResourceHolder created and file opened.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating ResourceHolder: {ex.Message}");
        }
    }

    public void WriteData(string data)
    {
        if (_disposed)
        {
            throw new ObjectDisposedException("ResourceHolder");
        }
        if (_fileStream != null)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(data + Environment.NewLine);
            _fileStream.Write(buffer, 0, buffer.Length);
            Console.WriteLine($"Data '{data}' written to file.");
        }
    }

    // Implementation of IDisposable
    public void Dispose()
    {
        Dispose(true);
        // Suppress finalization.
        GC.SuppressFinalize(this);
    }

    // Protected virtual dispose method
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            // Dispose of managed resources.
            if (_fileStream != null)
            {
                _fileStream.Close();
                _fileStream.Dispose();
                _fileStream = null;
                Console.WriteLine("File stream disposed.");
            }
        }

        // Dispose of unmanaged resources if any.

        _disposed = true;
    }

    // Finalizer (destructor) - only if there are unmanaged resources to release
    ~ResourceHolder()
    {
        Dispose(false);
        Console.WriteLine("ResourceHolder finalized.");
    }
}

