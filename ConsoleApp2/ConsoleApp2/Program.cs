using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement))
            {
                return new int[] { numDict[complement], i };
            }
            numDict[nums[i]] = i;
        }
        return new int[0];
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // Input your numbers and target here
        int[] nums = new int[] { 1, 2, 3 };
        int target = 4;

        Solution solution = new Solution();
        int[] result = solution.TwoSum(nums, target);

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}
