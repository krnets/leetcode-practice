/*public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int currMax = 0;
        int prevMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= currMax)
            {
                prevMax = currMax;
                currMax = nums[i];
            }
            else if (nums[i] > prevMax)
            {
                prevMax = nums[i];
            }
        }

        return (currMax - 1) * (prevMax - 1);
    }
}*/

using System;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        Array.Sort(nums);

        return (nums[^1] - 1) * (nums[^2] - 1);
    }
}