# ArrayAddress in C#

## Description
This C# program demonstrates how to retrieve and print the memory address of an integer array using unsafe code. Since C# does not allow direct access to raw memory addresses like C/C++, this program leverages the `unsafe` keyword and `fixed` statement to obtain a pointer to the first element of the array and print its memory address in both decimal and hexadecimal formats.

## Features
- Declares an integer array of size 10.
- Uses unsafe code to obtain the memory address of the first element.
- Prints the memory address in both decimal and hexadecimal format.

## Prerequisites
- .NET SDK installed
- A C# compiler that supports unsafe code execution

## How to Compile and Run
1. Enable unsafe code compilation:
   - If using the command line:
     ```sh
     csc /unsafe ArrayAddress.cs
     ```
   - If using Visual Studio, enable "Allow unsafe code" in project settings.

2. Run the compiled executable:
   ```sh
   ./ArrayAddress
   ```

## Code Overview
```csharp
using System;

public class ArrayAddress
{
    public static void Main(string[] args)
    {
        int[] a = new int[10]; // Declares an integer array 'a' with 10 elements.

        unsafe
        {
            fixed (int* ptr = a)
            {
                IntPtr address = (IntPtr)ptr;
                Console.WriteLine($"pointer address{address}");
                Console.WriteLine($"address{address.ToString()}");
                Console.WriteLine($"address in hexdeceimal {(long)ptr:X}"); // Prints address in hex
            }
        }
    }
}
```

## 32-bit vs. 64-bit Addressing
- **Memory Limitations:**
  - A **32-bit process** can access a maximum of **4 GB** of memory.
  - A **64-bit process** can access **much larger memory spaces**, theoretically up to **16 exabytes**.
- **Pointer Size:**
  - In a **32-bit system**, pointers are **4 bytes** in size.
  - In a **64-bit system**, pointers are **8 bytes** in size.
- **Checking Architecture in Code:**
  - You can check if your program is running in 32-bit or 64-bit mode by adding:
    ```csharp
    Console.WriteLine($"Pointer size: {IntPtr.Size * 8}-bit");
    ```
  - `IntPtr.Size` returns `4` for 32-bit and `8` for 64-bit.
- **Compilation Differences:**
  - Compile for **32-bit**:
    ```sh
    csc /platform:x86 /unsafe ArrayAddress.cs
    ```
  - Compile for **64-bit**:
    ```sh
    csc /platform:x64 /unsafe ArrayAddress.cs
    ```
- **Performance and Security:**
  - **64-bit systems** have better security, more registers, and better performance for memory-intensive applications.
  - **32-bit applications** use less memory and may run better on low-RAM systems.

## Notes
- The program must be compiled with the `/unsafe` flag because it uses pointers.
- The `fixed` keyword prevents the garbage collector from moving the array while the pointer is being used.
- This example is for educational purposes; accessing memory addresses manually is not common practice in C#.

## License
This project is released under the MIT License.

