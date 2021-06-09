using System;
using System.Linq;

/*public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var seqLengths = new int[nums.Length];

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    seqLengths[i] = Math.Max(seqLengths[i], 1 + seqLengths[j]);
                }
            }
        }

        return 1 + seqLengths.Max();
    }
}*/

public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        int n = nums.Length;
        int max = 0;
        var seqLengths = new int[n];

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (nums[i] < nums[j])
                {
                    seqLengths[i] = Math.Max(seqLengths[i], 1 + seqLengths[j]);
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            max = Math.Max(max, seqLengths[i]);
        }

        return 1 + max;
    }
}