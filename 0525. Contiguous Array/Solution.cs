using System;
using System.Collections.Generic;

public class Solution
{
    public int FindMaxLength(int[] nums)
    {
        int sum = 0;
        int res = 0;
        var map = new Dictionary<int, int> {{0, -1}};

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                sum++;
            else sum--;

            if (map.ContainsKey(sum))
                res = Math.Max(res, i - map[sum]);
            else map.Add(sum, i);
        }

        return res;
    }
}