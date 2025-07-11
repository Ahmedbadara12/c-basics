using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        // Uncomment the method you want to run:

        // IdentityMatrix();
         //SumOfArray();
        // MergeSortedArrays();
        // FrequencyCount();
        // MaxMinElement();
        // SecondLargestElement();
        // LongestDistanceBetweenEquals();
        // ReverseWords();
        // Copy2DArray();
        // ReverseArray();
    }

    // 19. Identity Matrix
    static void IdentityMatrix()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(i == j ? "1 " : "0 ");
            Console.WriteLine();
        }

        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine(); // prevents yellow underline
    }

    // 20. Sum of all elements in array
    static void SumOfArray()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (int num in arr)
            sum += num;

        Console.WriteLine("Sum of all elements: " + sum);
        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 21. Merge and sort arrays
    static void MergeSortedArrays()
    {
        Console.Write("Enter size of arrays: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr1 = new int[size];
        int[] arr2 = new int[size];

        Console.WriteLine("Enter elements for first array:");
        for (int i = 0; i < size; i++)
            arr1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements for second array:");
        for (int i = 0; i < size; i++)
            arr2[i] = int.Parse(Console.ReadLine());

        int[] merged = arr1.Concat(arr2).ToArray();
        Array.Sort(merged);

        Console.WriteLine("Merged and sorted array:");
        Console.WriteLine(string.Join(" ", merged));
        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 22. Frequency of elements
    static void FrequencyCount()
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = int.Parse(Console.ReadLine());

        bool[] visited = new bool[size];
        for (int i = 0; i < size; i++)
        {
            if (visited[i]) continue;
            int count = 1;
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            Console.WriteLine($"Element {arr[i]} occurs {count} times");
        }

        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 23. Max and Min
    static void MaxMinElement()
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Max: " + arr.Max());
        Console.WriteLine("Min: " + arr.Min());

        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 24. Second largest
    static void SecondLargestElement()
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Array.Sort(arr);
        Array.Reverse(arr);

        int largest = arr[0];
        for (int i = 1; i < size; i++)
        {
            if (arr[i] < largest)
            {
                Console.WriteLine("Second largest: " + arr[i]);
                Console.WriteLine("Press Enter to exit...");
                _ = Console.ReadLine();
                return;
            }
        }

        Console.WriteLine("No second largest value found.");
        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 25. Longest distance between equal elements
    static void LongestDistanceBetweenEquals()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int maxDist = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = size - 1; j > i; j--)
            {
                if (arr[i] == arr[j])
                {
                    maxDist = Math.Max(maxDist, j - i - 1);
                    break;
                }
            }
        }

        Console.WriteLine("Longest distance: " + maxDist);
        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 26. Reverse sentence
    static void ReverseWords()
    {
        Console.Write("Enter sentence: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));

        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 27. Copy 2D array
    static void Copy2DArray()
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter cols: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr1 = new int[rows, cols];
        int[,] arr2 = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                arr1[i, j] = int.Parse(Console.ReadLine());
                arr2[i, j] = arr1[i, j];
            }
        }

        Console.WriteLine("Copied array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(arr2[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }

    // 28. Reverse 1D array
    static void ReverseArray()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Array.Reverse(arr);
        Console.WriteLine("Reversed array: " + string.Join(" ", arr));

        Console.WriteLine("Press Enter to exit...");
        _ = Console.ReadLine();
    }
}
