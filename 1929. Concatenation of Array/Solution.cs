using System;
using System.Linq;

/*public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        return nums.Concat(nums).ToArray();
    }
}*/

/*public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int repeat = 2;
        int n = nums.Length;
        int[] ans = new int[repeat * n];
        int k = 0;

        while (k < repeat)
        {
            for (int i = 0; i < n; i++)
            {
                ans[k * n + i] = nums[i % n];
            }

            k++;
        }

        return ans;
    }
}*/

public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int repeat = 2;
        int n = nums.Length;
        int[] ans = new int[repeat * n];
        int k = 0;

        while (k < repeat)
        {
            Array.Copy(nums, 0, ans, k * n, n);
            k++;
        }

        return ans;
    }
}