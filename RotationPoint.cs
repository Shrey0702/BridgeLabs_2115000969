namespace ConsoleApp1;

using System;
class RotationPoint{
    static int FindRotationPoint(int[] arr){
        int left = 0, right = arr.Length - 1;
        while (left < right){
            int mid = left + (right - left) / 2;
            // if mid element is greater right, rotation point is on the right side
            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }
        return left; 
    }
    static void Main(){
        int[] rotatedArray = { 6, 7, 8, 1, 2, 3, 4, 5 };
        int index = FindRotationPoint(rotatedArray);
        Console.WriteLine("Rotation Point Index: " + index);
        Console.WriteLine("Smallest Element: " + rotatedArray[index]);
    }
}


