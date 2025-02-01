namespace ListAllProjectsInFolder;

internal class Program
{
    static void Main(string[] args)
    {
        string folderPath = @"C:\Git-Sree\DataStructExplorer\DSPlayground\Searching"; // Change this to your folder path

        if (Directory.Exists(folderPath))
        {
            string[] projectFiles = Directory.GetFiles(folderPath, "*.csproj", SearchOption.AllDirectories);

            Console.WriteLine("C# Projects found:");
            foreach (string file in projectFiles)
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file)); // Prints project name
            }
        }
        else
        {
            Console.WriteLine("Folder does not exist.");
        }
    }
}
