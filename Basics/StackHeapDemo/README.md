# Stack vs Heap in C#

## Overview
This program demonstrates how **Stack and Heap** memory works in C#. It covers:
- **Value types** (stored in Stack)
- **Reference types** (stored in Heap)
- **How variables interact with memory**

## Concepts
### **Stack**
- Stores **value types** (e.g., `int`, `double`, `char`)
- Fast allocation and deallocation (LIFO - Last In First Out)
- Local variables and method calls are stored here

### **Heap**
- Stores **reference types** (e.g., `class`, `array`, `string`)
- Objects remain in memory until garbage collection
- Slower allocation compared to Stack

## Code Breakdown

### **1. Value Type Example (Stack Allocation)**
```csharp
int a = 10;
int b = a;
b = 20;
```
- `a` and `b` are stored in the **Stack** separately.
- Changing `b` does **not** affect `a`.

### **2. Reference Type Example (Heap Allocation)**
```csharp
Person person1 = new Person { Name = "Alice", Age = 25 };
Person person2 = person1;
person2.Age = 30;
```
- `person1` and `person2` **both point to the same object in the Heap**.
- Changing `person2.Age` affects `person1.Age` as well.

## Execution Steps
1. **Compile the program** using:
   ```sh
   csc StackHeapDemo.cs
   ```
2. **Run the executable**:
   ```sh
   StackHeapDemo.exe
   ```

## Expected Output
```
--- Stack vs Heap Demonstration ---
Value Type Example: a = 10, b = 20
Reference Type Example: person1 Age = 30, person2 Age = 30
Stack Allocation Example: x = 5, y = 10
Heap Allocation Example: Bob, Age = 40
```

## Summary
- **Value types** are stored in the **Stack**, and each copy is independent.
- **Reference types** store references in the **Stack** but allocate memory in the **Heap**.
- Understanding Stack and Heap is crucial for performance and memory management in C#.

