# UnsafeCodeDemo

This project demonstrates the use of **unsafe code** in C# to perform pointer operations, directly manipulate memory, and interact with data at a low level. While C# is typically a memory-safe language, using `unsafe` blocks allows developers to bypass some of these safety features for performance or interoperability reasons.

## 🚀 Project Overview

The `UnsafeCodeDemo` project showcases:

- Declaring and using pointers in C#
- Accessing memory addresses
- Modifying variables and arrays via pointers
- Using the `fixed` statement to pin objects in memory

## 📌 Prerequisites

- .NET SDK installed (.NET Core or .NET 5+)
- Unsafe code compilation must be enabled:

  - In Visual Studio: Go to Project Properties > Build > Allow unsafe code
  - With `dotnet` CLI:

    ```bash
    dotnet build -p:AllowUnsafeBlocks=true
    ```

## 🧠 Key Concepts Demonstrated

### 1. **Pointer to a Variable**

```csharp
int number = 10;
int* pointerToNumber = &number;
*pointerToNumber = 25;
```

Modifies the value of `number` using direct memory access.

### 2. **Accessing Memory Addresses**

```csharp
Console.WriteLine($"Address of 'number': {(long)pointerToNumber:X}");
```

Prints the memory address of a variable using hexadecimal formatting.

### 3. **Fixed Statement with Arrays**

```csharp
fixed (int* pointerToArray = array)
```

Prevents the garbage collector from moving the array in memory, making it safe to use pointers.

### 4. **Array Element Modification via Pointers**

```csharp
*(pointerToArray + 2) = 100;
```

Directly updates an array element using pointer arithmetic.

## 🛠️ Real-World Use Cases

Unsafe code is not common in everyday C# development, but it’s invaluable in certain scenarios:

### ✅ Interoperability with Native Code

When working with native APIs or libraries (like calling C/C++ code from C#), pointer manipulation may be necessary for performance or compatibility.

### ✅ Performance-Critical Applications

Game engines, image processing, or real-time simulations sometimes bypass safety checks to reduce overhead and gain fine-grained memory control.

### ✅ Custom Memory Management

Advanced developers building memory pools or implementing unmanaged resource handling may use unsafe code to fine-tune control.

### ✅ Embedded Systems / Hardware Control

In systems interfacing with hardware (like IoT devices), unsafe code allows direct register/memory manipulation for precise control.

## ⚠️ Caution

Unsafe code sacrifices memory safety. Improper use can lead to:

- Memory leaks
- Application crashes
- Security vulnerabilities

Use it **only when absolutely necessary**, and thoroughly test such code.

## ▶️ How to Run

```bash
dotnet run --project UnsafeCodeDemo.csproj
```

Make sure the project is compiled with unsafe code allowed.

## 📄 License

This project is licensed under the MIT License.
