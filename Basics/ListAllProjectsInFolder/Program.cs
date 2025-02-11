using System.Diagnostics;

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
            foreach (string project in projectFiles)
            {
                //Console.WriteLine(Path.GetFileNameWithoutExtension(project));
                Console.WriteLine($"Building: {Path.GetFileName(project)}");

                // Build the projects
                RunCommand("dotnet", $"build \"{project}\"");// Prints project name
            }
        }
        else
        {
            Console.WriteLine("Folder does not exist.");
        }
    }

    static void RunCommand(string command, string args)
    {
        ProcessStartInfo psi = new ProcessStartInfo
        {
            FileName = command,
            Arguments = args,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using (Process process = new Process { StartInfo = psi })
        {
            process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
            process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }
    }
}
