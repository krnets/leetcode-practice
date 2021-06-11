using System;
using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public IList<int> MinSubsequence(int[] nums)
    {
        Array.Sort(nums, (a, b) => b - a);

        int sumRem = nums.Sum();
        int sumAsc = 0;
        int i = 0;
        int n = nums.Length;

        while (i < n)
        {
            sumAsc += nums[i];
            sumRem -= nums[i];

            if (sumAsc > sumRem)
                break;

            i++;
        }

        return nums[..(i + 1)];
    }
}*/

public class Solution
{
    public IList<int> MinSubsequence(int[] nums)
    {
        Array.Sort(nums, (a, b) => b - a);

        int sumRem = 0;
        int sumAsc = 0;
        int i = 0;
        int n = nums.Length;

        for (int j = 0; j < n; j++)
        {
            sumRem += nums[j];
        }

        while (i < n)
        {
            sumAsc += nums[i];
            sumRem -= nums[i];

            if (sumAsc > sumRem)
                break;

            i++;
        }

        return nums[..(i + 1)];
    }
}