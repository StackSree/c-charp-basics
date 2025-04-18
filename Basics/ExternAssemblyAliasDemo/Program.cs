namespace ExternAssemblyAliasDemo;

internal class Program
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            // Using the full qualified names with aliases
            GridV1.Grid grid1 = new GridV1.Grid();
            GridV2.Grid grid2 = new GridV2.Grid();

            Console.WriteLine($"Grid 1 Version: {grid1.Version}");
            grid1.DisplayVersion();
            Console.WriteLine();
            Console.WriteLine($"Grid 2 Version: {grid2.Version}");
            grid2.DisplayVersion();

            Console.ReadKey();
        }
    }
}
