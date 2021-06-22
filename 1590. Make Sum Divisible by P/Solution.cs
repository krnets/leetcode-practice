using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MinSubarray(int[] nums, int p)
    {
        int n = nums.Length;
        int minLen = n;
        int prefixSum = 0;
        int remainder = nums.Aggregate(0, (cur, num) => (cur + num) % p);

        if (remainder == 0)
            return 0;

        var prefixSumToIndex = new Dictionary<int, int> {{prefixSum, -1}};

        for (int i = 0; i < n; i++)
        {
            prefixSum = (prefixSum + nums[i]) % p;
            int key = (prefixSum - remainder + p) % p;

            if (prefixSumToIndex.ContainsKey(key))
            {
                minLen = Math.Min(minLen, i - prefixSumToIndex[key]);
            }

            prefixSumToIndex[prefixSum] = i;
        }

        return minLen == n ? -1 : minLen;
    }
}