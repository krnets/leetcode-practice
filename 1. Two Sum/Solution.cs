/*public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int delta = target - nums[i];

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] == delta)
                    return new[] {i, j};
            }
        }

        return new int[0];
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var deltasMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var delta = target - nums[i];

            if (deltasMap.ContainsKey(delta))
                return new[] {deltasMap[delta], i};

            deltasMap.Add(nums[i], i);
        }

        return new int[0];
    }
}