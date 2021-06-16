using System;

public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int minLen = int.MaxValue;
        int left = 0, right = 0, sum = 0;

        while (right < nums.Length)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left];
                left++;
            }

            right++;
        }

        return minLen == int.MaxValue ? 0 : minLen;
    }
}