using System.Diagnostics;

namespace ConsoleApp1;

public class SearchComparision
{
    static int LinerSearch(int[] arr,  int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int start, int end, int target)
    {
        int left = start, right = end;
        while (left <= right)
        {
            int mid = (start + end) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] > target)
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }

        return -1;
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

    public static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        int[] arr = new int[1000001];
        for (int i = 0; i < 1000001; i++)
        {
            arr[i] = i;
        }
        sw.Start();
        int resLinear = LinerSearch(arr, 999999);
        sw.Stop();
        Console.WriteLine($"Linear search time: {sw.ElapsedMilliseconds} ms and the target is at the index of {resLinear}");
        sw.Reset();
        MergeSort(arr, 0, arr.Length - 1);
        sw.Start();
        int resBinary = BinarySearch(arr, 0, arr.Length, 999999);
        sw.Stop();
        Console.WriteLine($"Binary Search time: {sw.ElapsedMilliseconds} ms and the target is at the {resBinary}");
    }
}