using System;

class QuickSort
{
    static void Main()
    {
        int[] array = { 8, 2, 9, 1, 4, 5, 6 };

        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        QuickSortArray(array, 0, array.Length - 1);

        Console.WriteLine("\nВiдсортований масив:");
        PrintArray(array);
    }

    static void QuickSortArray(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSortArray(arr, left, pivotIndex - 1);
            QuickSortArray(arr, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
