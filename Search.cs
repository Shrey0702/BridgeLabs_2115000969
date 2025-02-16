namespace ConsoleApp1;

using System;
class Search{
    static int FindFirstMissingPositive(int[] nums){
        int n = nums.Length;
        // placing each number at its correct position
        for (int i = 0; i < n; i++){
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]){
                // swapping nums[i] & nums[nums[i] - 1]
                int temp = nums[i];
                nums[i] = nums[temp - 1];
                nums[temp - 1] = temp;
            }
        }
        // finding the first missing positive number
        for (int i = 0; i < n; i++){
            if (nums[i] != i + 1)
                return i + 1;
        }
        return n + 1;
    }
    static int BinarySearch(int[] nums, int target){
        // sorting the array first
        Array.Sort(nums); 
        int left = 0, right = nums.Length - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
    static void Main(){
        int[] nums = { 3, 4, -1, 1 };
        int target = 4;
        int missing = FindFirstMissingPositive(nums);
        Console.WriteLine($"First Missing Positive Integer: {missing}");
        int targetIndex = BinarySearch(nums, target);
        Console.WriteLine($"Index of {target} after sorting: {targetIndex}");
    }
}


