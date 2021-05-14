/*
using System;
using System.Linq;

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int res = nums.Take(k).Sum();
        int sum = res;

        for (int i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            res = Math.Max(sum, res);
        }

        return (double) res / k;
    }
}
*/

public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        long res = 0;

        for (int i = 0; i < k; i++)
            res += nums[i];

        long sum = res;

        for (int i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];

            if (res < sum)
                res = sum;
        }

        return res / (double) k;
    }
}