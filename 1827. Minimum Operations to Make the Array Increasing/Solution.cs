/*public class Solution
{
    public int MinOperations(int[] nums)
    {
        int opsCount = 0, prev, curr, nextHigher;

        for (int i = 1; i < nums.Length; i++)
        {
            prev = nums[i - 1];
            curr = nums[i];

            if (prev >= curr)
            {
                nextHigher = prev + 1;
                opsCount += nextHigher - curr;
                nums[i] = nextHigher;
            }
        }

        return opsCount;
    }
}*/

using System;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        int opsCount = 0, diff;

        for (int i = 1; i < nums.Length; i++)
        {
            diff = Math.Max(0, nums[i - 1] - nums[i] + 1);
            opsCount += diff;
            nums[i] += diff;
        }

        return opsCount;
    }
}