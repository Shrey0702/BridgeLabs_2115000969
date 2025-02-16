namespace ConsoleApp1;

using System;
class FirstLastOccurrence{
    static int FindFirstOccurrence(int[] arr, int target){
        int left = 0, right = arr.Length - 1, first = -1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            if (arr[mid] == target){
                // if target found , move left
                first = mid;  
                right = mid - 1;
            }
            else if (arr[mid] < target){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return first;
    }
    static int FindLastOccurrence(int[] arr, int target){
        int left = 0, right = arr.Length - 1, last = -1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            // if target found , move right
            if (arr[mid] == target){
                last = mid; 
                left = mid + 1;
            }
            else if (arr[mid] < target){
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return last;
    }
    static int[] FindFirstAndLastOccurrence(int[] arr, int target){
        return new int[] { FindFirstOccurrence(arr, target), FindLastOccurrence(arr, target) };
    }
    static void Main(){
        int[] arr = {1, 2, 2, 2, 3, 4, 5, 5, 5, 6};
        int target = 2;
        int[] result = FindFirstAndLastOccurrence(arr, target);
        Console.WriteLine($"First Occurred: {result[0]}, Last Occurred: {result[1]}");
    }
}


