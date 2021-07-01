using System.Collections.Generic;

public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        var prefixSums = new Dictionary<int, int> {[0] = 1};
        int curSum = 0;
        int result = 0;

        foreach (var x in nums)
        {
            curSum += x;
            result += prefixSums.GetValueOrDefault(curSum - k, 0);

            if (prefixSums.ContainsKey(curSum))
                prefixSums[curSum]++;
            else prefixSums[curSum] = 1;
        }

        return result;
    }
}


/*public class Solution // brute force slowest 9%, whereas best memory 97%
{
    public int SubarraySum(int[] nums, int k)
    {
        int ans = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int sum = 0;
            int end = i;

            while (end < nums.Length)
            {
                sum += nums[end];
                end++;

                if (sum == k) 
                    ans++;
            }
        }

        return ans;
    }
}*/