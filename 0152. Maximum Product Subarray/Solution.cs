using System;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int maxProduct = nums[0];
        int currMin = nums[0];
        int currMax = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int num = nums[i];
            int min = currMin * num;
            int max = currMax * num;

            currMin = Math.Min(num, Math.Min(min, max));
            currMax = Math.Max(num, Math.Max(min, max));

            maxProduct = Math.Max(maxProduct, currMax);
        }

        return maxProduct;
    }
}