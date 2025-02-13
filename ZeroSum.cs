using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    public static void FindZeroSumSubarrays(int[] nums)
    {
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;

        sumMap[0] = new List<int> { -1 };

        for (int i = 0; i < nums.Length; i++)
        {
            cumulativeSum += nums[i];

            if (sumMap.ContainsKey(cumulativeSum))
            {
                foreach (int startIndex in sumMap[cumulativeSum])
                {
                    Console.WriteLine($"Subarray found: [{startIndex + 1}, {i}]");
                }
            }

            if (!sumMap.ContainsKey(cumulativeSum))
                sumMap[cumulativeSum] = new List<int>();

            sumMap[cumulativeSum].Add(i);
        }
    }

    public static void Main()
    {
        int[] nums = { 3, 2, -7, 5, 6, 3, 1, 2, -2, -2 };
        FindZeroSumSubarrays(nums);
    }
}
