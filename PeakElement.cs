namespace ConsoleApp1;

using System;
class PeakElement{
    static int FindPeak(int[] arr){
        int left = 0, right = arr.Length - 1;
        while (left < right){
            int mid = left + (right - left) / 2;
            
            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }
        // peak element index
        return left-1; 
    }
    static void Main(){
        int[] rotatedArray = {3,6,8,9,1,2,3,4,5};
        int index = FindPeak(rotatedArray);
        Console.WriteLine("Peak Index: " + index);
        Console.WriteLine("Peak Element: " + rotatedArray[index]);
    }
}
