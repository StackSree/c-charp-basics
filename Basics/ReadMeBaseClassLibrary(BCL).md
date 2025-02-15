Here's a concise summary with a demo-style example:  

### **Platform Support in C#**  
C# supports various platforms:  
- **Windows (7+)** – Desktop, web, server, and command-line apps  
- **macOS** – Web, CLI, and rich-client apps (via Mac Catalyst)  
- **Linux** – Web and CLI applications  
- **Android & iOS** – Mobile applications  
- **Windows 10 devices** – Xbox, Surface Hub, HoloLens (via UWP)  
- **Blazor** – Runs C# in a browser via WebAssembly  

### **Demo: Cross-Platform "Hello, World!" in C#**  

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```
- Run this on **Windows, macOS, or Linux** using .NET SDK (`dotnet run`).  
- Use **Blazor** to display it in a browser.  
- Compile for **Android/iOS** using .NET MAUI.  
