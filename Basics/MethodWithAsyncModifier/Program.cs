namespace MethodWithAsyncModifier;

internal class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine($"Start of Main on thread: {Environment.CurrentManagedThreadId}");

        string websiteContent = await DownloadWebsiteContentAsync("https://www.google.com");
        Console.WriteLine($"Website content length: {websiteContent?.Length ?? 0}");

        Console.WriteLine($"End of Main on thread: {Environment.CurrentManagedThreadId}");
    }

    public static async Task<string> DownloadWebsiteContentAsync(string url)
    {
        Console.WriteLine($"Starting DownloadWebsiteContentAsync on thread: {Environment.CurrentManagedThreadId}");

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // This is the asynchronous operation. The 'await' keyword will pause execution here.
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Throw an exception for bad status codes

                string content = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Finished DownloadWebsiteContentAsync on thread: {Environment.CurrentManagedThreadId}");
                return content;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error downloading website: {e.Message}");
                return null;
            }
        }
    }

    public static void DoSomeOtherWork()
    {
        Console.WriteLine($"Doing some other work on thread: {Environment.CurrentManagedThreadId}");
        // Simulate some CPU-bound work
        for (int i = 0; i < 100000; i++)
        {
            Math.Sqrt(i);
        }
        Console.WriteLine($"Finished other work on thread: {Environment.CurrentManagedThreadId}");
    }
}


