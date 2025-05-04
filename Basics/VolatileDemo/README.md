# VolatileDemo

A C# console application that demonstrates the difference between **volatile** and **non-volatile** fields in a multi-threaded environment.

## 🧠 Purpose

This project illustrates how variable visibility and memory consistency work between threads in .NET, particularly:

- How a non-volatile variable may not reflect the updated value across threads due to CPU caching and compiler optimizations.
- How a volatile variable ensures visibility of changes across threads immediately.

---

## 🚀 How It Works

The application launches two sets of threads:

1. **Non-Volatile Section**:

   - A writer thread updates `_isReadyNonVolatile` and `_valueNonVolatile`.
   - A reader thread spins in a `while` loop waiting for `_isReadyNonVolatile` to become true.
   - Due to lack of the `volatile` keyword, changes made by the writer thread might not be seen by the reader thread immediately.

2. **Volatile Section**:

   - Similarly, but with `volatile` applied to `_isReadyVolatile` and `_valueVolatile`.
   - Ensures changes are visible across threads right away.

---

## 🧪 Real-Time Use Cases

### Where volatile is useful:

- Simple flags or status indicators shared across threads.
- Cancellation tokens or "is-running" states.
- Spin-wait scenarios.

```csharp
private static volatile bool _cancelRequested;

void Worker()
{
    while (!_cancelRequested)
    {
        // do work
    }
}
```

---

## ✅ Pros and ❌ Cons

### ✅ Pros of `volatile`:

- Guarantees **visibility**: changes are seen across threads immediately.
- Simple to use for **single-variable** synchronization.
- Avoids some locking overhead.

### ❌ Cons of `volatile`:

- Does **not** guarantee **atomicity** for compound operations (e.g., increment).
- Not suitable for synchronization involving **multiple variables**.
- Limited to simple use cases (e.g., flags).

---

## 🧩 Alternative Approaches

| Approach                             | Use Case                           | Advantages                            | Disadvantages                  |
| ------------------------------------ | ---------------------------------- | ------------------------------------- | ------------------------------ |
| `lock` (Monitor)                     | Complex shared data                | Ensures atomicity + memory visibility | Slower due to context switches |
| `Interlocked` class                  | Atomic operations (e.g., counters) | Fast, atomic                          | Limited to primitive types     |
| `ManualResetEvent`, `AutoResetEvent` | Signaling between threads          | Explicit signaling                    | Slightly more complex          |
| `volatile` keyword                   | Visibility of simple flags         | Lightweight                           | No atomicity                   |

---

## 🛠 How to Run

1. Clone or download the repository.
2. Open the solution in Visual Studio or run the `.cs` file via .NET CLI:

   ```bash
   dotnet run
   ```

3. Observe the console output to see how threads behave with and without `volatile`.

---

## 📚 References

- [Microsoft Docs: volatile (C# Reference)](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/volatile)
- [Thread.MemoryBarrier Method](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.memorybarrier)

---

Would you like a diagram to visually explain how `volatile` ensures memory visibility across CPU cores?
