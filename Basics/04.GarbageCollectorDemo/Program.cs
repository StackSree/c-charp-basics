namespace _04.GarbageCollectorDemo;

internal class Program
{

    /*

        The initial memory and memory after deallocation will not necessarily be the same in the given code. Here’s why:
        Why Doesn’t Memory Return to Initial Levels After GC?
        Memory Fragmentation:
            The CLR heap can become fragmented, leading to memory not being immediately returned to the OS even after garbage collection.
        GC Overhead & Reserved Memory:
            The garbage collector doesn't always immediately release memory back to the operating system. Instead, it might retain some of it for future allocations to improve performance.
        Heap Growth & GC Behavior:
            The managed heap may have grown due to object allocations, and while GC will clean up unused objects, the heap itself may not shrink immediately.
        Finalization Delay:
            Objects with finalizers (~DemoObject()) are first placed in the finalization queue, and only in the next GC cycle are they fully cleaned up.
    
     * Conclusion
            GC does not immediately return memory to the OS, but it does clean up unreferenced objects.
            The heap may retain extra memory for performance reasons.
            To force memory release, multiple GC.Collect() calls can help, but OS-level behavior may still retain memory for future allocations.     
     */


    static void Main(string[] args)
    {
        Console.WriteLine("GC Demo Started");
        Console.WriteLine($"Initial Memory: {GC.GetTotalMemory(false)} bytes");

        // Allocate memory
        for (int i = 0; i < 10; i++)
        {
            var obj = new DemoObject();
        }

        Console.WriteLine($"Memory Before De-Allocation: {GC.GetTotalMemory(false)} bytes");

        // Force garbage collection
        // But even with this, the CLR does not guarantee immediate memory release.
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect(); // Call again to ensure objects finalized
        GC.WaitForFullGCComplete();

        Console.WriteLine($"Memory After De-Allocation: {GC.GetTotalMemory(false)} bytes");

        Console.ReadKey();

    }

    class DemoObject
    {
        public DemoObject()
        {
            Console.WriteLine("DemoObject Created");
        }

        ~DemoObject()
        {
            Console.WriteLine("Finalizer called for DemoObject.");
        }
    }
}

