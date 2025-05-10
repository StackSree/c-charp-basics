# MethodWithAsyncModifier

This is a simple C# console application demonstrating the use of the `async` and `await` keywords for asynchronous programming. The application asynchronously downloads content from a specified website (e.g., https://www.google.com) and prints its length.

## Features

- Demonstrates how `async` and `await` work in C#.
- Uses `HttpClient` to perform an asynchronous HTTP GET request.
- Prints thread IDs to show where the asynchronous code is executing.
- Includes an example method (`DoSomeOtherWork`) that simulates CPU-bound operations.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (.NET Core 3.1 or later)

### Running the Program

1. Clone the repository or copy the code into a new console application.
2. Open a terminal and navigate to the project folder.
3. Run the following commands:

```bash
dotnet build
dotnet run
```

### Output Example

```plaintext
Start of Main on thread: 1
Starting DownloadWebsiteContentAsync on thread: 1
Finished DownloadWebsiteContentAsync on thread: 4
Website content length: 12560
End of Main on thread: 1
```

(Note: Thread IDs may vary.)

## Code Structure

- `Main`: The entry point. Calls `DownloadWebsiteContentAsync` and prints output.
- `DownloadWebsiteContentAsync`: Asynchronously fetches website content using `HttpClient`.
- `DoSomeOtherWork`: Simulates a CPU-bound task for educational purposes.

## Concepts Demonstrated

- **Asynchronous programming** with `async/await`
- **Thread context switching**
- **HttpClient usage** for HTTP requests
- **Exception handling** with `try-catch`

## License

This project is open source and available under the [MIT License](LICENSE).
