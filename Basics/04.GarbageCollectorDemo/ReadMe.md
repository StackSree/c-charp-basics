# C# Garbage Collection (GC) Demo

## Overview
This project demonstrates how C# manages memory using **Garbage Collection (GC)**. The example shows:
- How memory usage changes before and after object allocation.
- How to trigger **manual garbage collection**.
- Why memory might not return to its initial value after GC execution.

## Features
- Tracks memory usage before and after object allocation.
- Uses `GC.Collect()` to manually trigger garbage collection.
- Demonstrates object **finalization** when objects are destroyed.

## Code Explanation
```csharp
using System;

class DemoObject
{
    public DemoObject()
    {
        Console.WriteLine("DemoObject Created");
    }

    ~DemoObject()
    {
        Console.WriteLine("DemoObject Destroyed");
    }
}

class Program
{
    static void Main()
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
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Memory After De-Allocation: {GC.GetTotalMemory(false)} bytes");

        Console.ReadKey();
    }
}
```

## Expected Output
```
GC Demo Started
Initial Memory: 25,000 bytes
DemoObject Created
DemoObject Created
...
DemoObject Created
Memory Before De-Allocation: 50,000 bytes
DemoObject Destroyed
DemoObject Destroyed
...
DemoObject Destroyed
Memory After De-Allocation: 35,000 bytes
```

## Why Doesn't Memory Return to Initial Value?
1. **Heap Fragmentation**: The CLR heap may retain allocated memory for future use.
2. **Garbage Collector Optimization**: The GC may not immediately release memory to the OS.
3. **Finalization Delay**: Objects with finalizers (`~DemoObject()`) are collected in a later GC cycle.

## How to Force Memory Release?
If you want to release unused memory back to the **OS**, use:
```csharp
GC.Collect();
GC.WaitForPendingFinalizers();
GC.Collect();
GC.WaitForFullGCComplete();
```
> **Note:** Even with this, the CLR may retain memory based on internal optimizations.

## Run Instructions
1. Open the project in **Visual Studio** or any C# IDE.
2. Run the program and observe the memory usage changes.
3. Press any key to exit.

## License
This project is open-source under the **MIT License**.

