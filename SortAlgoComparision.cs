using System.Collections.Concurrent;
using System.Diagnostics;

namespace ConsoleApp1;

public class SortAlgoComparision
{
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    
    static void MergeSort(int[] arr, int start, int end)
    {
        if(start >= end){return;}
        int mid = start + (end - start) / 2;
        MergeSort(arr, start, mid);
        MergeSort(arr, mid + 1, end);
        Merge(arr, start, mid, end);
    }

    static void Merge(int[] arr, int start, int mid, int end)
    {
        int left = start;
        int right = mid + 1;
        int k = 0;
        int[] temp = new int[end - start + 1];
        while (left <= mid && right <= end)
        {
            if (arr[left] > arr[right])
            {
                temp[k] = arr[right++];
            }
            else
            {
                temp[k] = arr[left++];
            }
            k++;
        }

        while (left <= mid)
        {
            temp[k++] = arr[left++];
        }

        while (right <= end)
        {
            temp[k++] = arr[right++];
        }

        for (int i = 0; i < temp.Length; i++)
        {
            arr[i + start] = temp[i];
        }
    }

    

    static void QuickSort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int partitonIndex = Partition(arr, start, end);
            QuickSort(arr, start, partitonIndex - 1);
            QuickSort(arr, partitonIndex + 1, end);
        }
    }
    
    static int Partition(int[] arr, int start, int end)
    {
        int pivot = arr[end];
        int i = start - 1;
        int j = start;
        while (j < end)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            j++;
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[end];
        arr[end] = temp2;
        
        return i + 1;

    }

    public static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        int[] arr = new int[10000];
        Random random = new Random();
        // creating random array
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(0, 10001);
        }
        sw.Start();
        QuickSort(arr, 0, arr.Length - 1);
        sw.Stop();
        Console.WriteLine($"Quick Sort: {sw.ElapsedMilliseconds}");
        sw.Reset();
        sw.Start();
        BubbleSort(arr);
        sw.Stop();
        Console.WriteLine($"Bubble Sort: {sw.ElapsedMilliseconds}");
        sw.Reset();
        sw.Start();
        MergeSort(arr, 0, arr.Length - 1);
        sw.Stop();
        Console.WriteLine($"Merge Sort: {sw.ElapsedMilliseconds}");
        sw.Reset();
        
        
    }
}