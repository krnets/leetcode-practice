using System;

public class Solution
{
    public int SmallestRangeI(int[] nums, int k)
    {
        int min = nums[0];
        int max = nums[0];

        foreach (int x in nums)
        {
            min = Math.Min(min, x);
            max = Math.Max(max, x);
        }

        return Math.Max(max - min - 2 * k, 0);
    }
}

/*using System;

public class Solution
{
    public int SmallestRangeI(int[] nums, int k)
    {
        Array.Sort(nums);
        int min = nums[0];
        int max = nums[^1];

        return Math.Max(max - min - 2 * k, 0);
    }
}*/

/*public class Solution
{
    public int SmallestRangeI(int[] nums, int k)
    {
        Array.Sort(nums);
        int min = nums[0] + k;
        int max = nums[^1] - k;

        return Math.Max(max - min, 0);
    }
}*/