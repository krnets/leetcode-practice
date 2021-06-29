using System;
using System.Collections.Generic;

public class Solution
{
    public int MaxResult(int[] nums, int k)
    {
        var dp = new int[nums.Length];
        Array.Fill(dp, int.MinValue);

        dp[0] = nums[0];
        k++;
        var queue = new List<int> {0};

        for (int i = 1; i < nums.Length; i++)
        {
            if (i >= k && queue[0] == i - k)
                queue.RemoveAt(0);

            dp[i] = nums[i] + dp[queue[0]];

            while (queue.Count > 0 && dp[i] >= dp[queue[^1]])
                queue.RemoveAt(queue.Count - 1);

            queue.Add(i);
        }

        return dp[^1];
    }
}