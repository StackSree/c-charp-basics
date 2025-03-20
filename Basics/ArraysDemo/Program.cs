namespace ArraysDemo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==== Basic Array Declaration & Initialization ====");
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("First Element: " + numbers[0]);

        Console.WriteLine("\n==== Looping Through an Array ====");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }

        Console.WriteLine("\nUsing foreach loop:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\n==== Multi-Dimensional Array ====");
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matrix element at [1,2]: " + matrix[1, 2]);

        Console.WriteLine("\nPrinting 2D Matrix:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n==== Jagged Array ====");
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        Console.WriteLine("Jagged Array element at [1][2]: " + jaggedArray[1][2]);

        Console.WriteLine("\nPrinting Jagged Array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n==== Sorting an Array ====");
        Array.Sort(numbers);
        Console.WriteLine("Sorted Array: " + string.Join(", ", numbers));

        Console.WriteLine("\n==== Reversing an Array ====");
        Array.Reverse(numbers);
        Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));

        Console.WriteLine("\n==== Finding Elements in an Array ====");
        int index = Array.IndexOf(numbers, 30);
        Console.WriteLine("Index of 30: " + index);

        Console.WriteLine("\n==== Copying an Array ====");
        int[] copiedArray = new int[numbers.Length];
        Array.Copy(numbers, copiedArray, numbers.Length);
        Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));

        Console.WriteLine("\n==== Resizing an Array ====");
        Array.Resize(ref numbers, 7);
        numbers[5] = 60;
        numbers[6] = 70;
        Console.WriteLine("Resized Array: " + string.Join(", ", numbers));

        Console.WriteLine("\n==== Using List<T> Instead of Arrays ====");
        List<int> numList = new List<int> { 1, 2, 3 };
        numList.Add(4);
        numList.Remove(2);

        Console.WriteLine("List: " + string.Join(", ", numList));
    }
}
