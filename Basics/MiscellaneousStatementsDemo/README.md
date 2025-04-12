# MiscellaneousStatementsDemo

This is a simple C# console application that demonstrates two fundamental concepts in .NET programming:

1. **The `using` statement** with the `IDisposable` interface for resource management.
2. **The `lock` statement** for thread-safe operations in multithreaded environments.

## 🧰 Features

### 1. **Using Statement with IDisposable**

- Ensures that resources (like file handles) are automatically released when no longer needed.
- Demonstrated using the custom `ResourceHolder` class, which wraps a `FileStream` and implements the `IDisposable` pattern.

### 2. **Lock Statement for Thread Synchronization**

- Demonstrates safe incrementing of a shared counter variable across multiple threads.
- Uses the `lock` statement to prevent race conditions.

3. **Expected Output**
   - File write operations and disposal confirmation.
   - Output from multiple threads showing thread-safe counter increments.
   - Final counter value reflecting the total number of increments.

## 📌 Notes

- The `ResourceHolder` class follows best practices by implementing both `IDisposable` and a finalizer.
- Threading behavior may vary slightly between executions due to thread scheduling by the OS.

## 📄 License

This project is provided for educational purposes and is free to use and modify.
