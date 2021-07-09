using System;

public class Solution
{
    public int FindLength(int[] nums1, int[] nums2)
    {
        int ans = 0;
        int m = nums1.Length + 1;
        int n = nums2.Length + 1;
        int[,] dp = new int[m, n];

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (nums1[i - 1] == nums2[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                    ans = Math.Max(ans, dp[i, j]);
                }
            }
        }

        return ans;
    }
}