# Common Language Runtime (CLR) & Just-In-Time (JIT) Compilation

## Overview
The **Common Language Runtime (CLR)** is the runtime environment for .NET applications, providing essential services such as:
- **Automatic memory management** (Garbage Collection)
- **Exception handling**
- **Just-In-Time (JIT) compilation**
- **Ahead-of-Time (AOT) compilation** (for performance and mobile app compliance)

## Managed Code & Intermediate Language (IL)
C# is a **managed language**, meaning:
- It compiles source code into **Intermediate Language (IL)** instead of direct machine code.
- The CLR **converts IL to native machine code** (e.g., x64, x86) during execution via **JIT compilation**.
- **AOT compilation** can be used for faster startup times and mobile app store requirements.

## Just-In-Time (JIT) Compilation
### How JIT Works
1. **C# code** is compiled into **IL** and stored in an **assembly (.exe or .dll)**.
2. When the application runs, the **CLR loads the IL** and identifies methods that need execution.
3. The **JIT compiler translates IL to native machine code** (e.g., x64 or ARM) at runtime.
4. The compiled native code is stored in memory for reuse, improving performance.

### Types of JIT Compilation
- **Normal JIT**: Compiles methods when they are first called and stores them in memory for future use.
- **Econo JIT**: Compiles methods at runtime but does not cache them, reducing memory usage.
- **Pre-JIT (Ahead-of-Time, AOT)**: Compiles the entire application before execution, improving startup times (used in **ReadyToRun (R2R)** and **NativeAOT**).

### Advantages of JIT Compilation
✅ **Platform Independence** – IL can run on different architectures.  
✅ **Optimized Execution** – Methods are compiled only when needed, reducing initial load time.  
✅ **Adaptive Performance** – Optimizations based on actual runtime conditions.  

## Assemblies & Metadata
- Code is stored in **assemblies**, which contain:
  - **IL code**
  - **Metadata** (type information)
- Metadata enables referencing types across assemblies without additional files.

## Tools for IL & Decompilation
You can inspect and decompile IL using:
- **ildasm** (Microsoft's IL Disassembler)
- **ILSpy** (Open-source decompiler)
- **JetBrains dotPeek** (Decompiler for .NET assemblies)

## Reflection & Dynamic Code Generation
- **Reflection** allows programs to inspect their own metadata at runtime.
- **Reflection.Emit** enables generating new IL dynamically.

---

### Example: Inspecting an Assembly with `ildasm`
```sh
ildasm MyProgram.exe
```
This command opens the IL Disassembler to inspect the IL code inside `MyProgram.exe`.

### Example: Viewing JIT Compilation in Action
Use **dotnet trace** to analyze JIT compilation:
```sh
dotnet trace collect --process-id <pid>
```
This command captures JIT events for performance analysis.

---

For more details, refer to the official [Microsoft .NET documentation](https://learn.microsoft.com/en-us/dotnet/standard/clr/).
