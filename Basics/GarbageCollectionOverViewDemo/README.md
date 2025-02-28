# .NET Core Garbage Collection (GC) Overview

## Introduction
The .NET Core Garbage Collector (GC) is responsible for managing memory allocation and deallocation in your application. It automatically reclaims memory occupied by objects that are no longer in use, preventing memory leaks and optimizing performance.

## How Garbage Collection Works
### 1. **Memory Allocation**
When you create a new object, the GC allocates memory for it on the heap.

### 2. **Generational Heap Structure**
The heap is divided into three generations:
- **Generation 0**: Stores newly created objects.
- **Generation 1**: Stores objects that have survived at least one garbage collection cycle.
- **Generation 2**: Stores long-lived objects that have survived multiple cycles.

### 3. **Mark and Sweep Process**
- The GC periodically scans the heap to mark objects that are still in use (reachable from the application's root).
- Unreachable objects are considered garbage and marked for deletion.

### 4. **Heap Compaction**
- After identifying garbage objects, the GC reclaims their memory.
- The heap is compacted to reduce fragmentation and improve performance.

### 5. **Generational Collection Strategy**
- The GC collects younger generations (Gen 0 and Gen 1) more frequently, as they contain more short-lived objects.
- Older generations (Gen 2) are collected less often to optimize performance.

## Value Types vs. Reference Types
### **Value Types**
- Store data directly and are typically allocated on the stack.
- Automatically deallocated when they go out of scope.
- Examples: `int`, `bool`, `struct`.

### **Reference Types**
- Store a reference to the data’s location in memory and are allocated on the heap.
- Managed by the GC.
- Examples: `class`, `interface`, `array`.

## Resources for Further Learning
- [Microsoft Documentation: Memory management and garbage collection (GC) in ASP.NET Core](https://docs.microsoft.com/en-us/dotnet/core/)

## Conclusion
Understanding how the GC works and the difference between value and reference types can help you write more efficient .NET Core applications. Proper memory management leads to better application performance and reduced memory footprint.

