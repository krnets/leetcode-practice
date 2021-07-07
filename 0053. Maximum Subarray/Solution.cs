using System;

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int currentSum = 0;
        int maxSub = nums[0];

        foreach (int num in nums)
        {
            if (currentSum < 0)
                currentSum = 0;

            currentSum += num;
            maxSub = Math.Max(maxSub, currentSum);
        }

        return maxSub;
    }
}