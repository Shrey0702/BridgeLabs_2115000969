using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    public static bool HasPairWithSum(int[] nums, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in nums)
        {
            int complement = target - num;
            if (seenNumbers.Contains(complement))
            {
                Console.WriteLine($"Pair found: ({complement}, {num})");
                return true;
            }
            seenNumbers.Add(num);
        }

        return false;
    }

    public static void Main()
    {
        int[] nums = { 9, 9, 12, 5 };
        int target = 18;

        if (!HasPairWithSum(nums, target))
            Console.WriteLine("No pair found.");
    }
}
