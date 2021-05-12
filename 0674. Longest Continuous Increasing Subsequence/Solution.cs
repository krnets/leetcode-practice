/*using System;

public class Solution
{
    public int FindLengthOfLCIS(int[] nums)
    {
        int longest = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 1;

            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j - 1] < nums[j]) count++;
                else break;
            }

            longest = Math.Max(longest, count);
        }

        return longest;
    }
}*/

using System;

public class Solution
{
    public int FindLengthOfLCIS(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        int max = 1, current = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] < nums[i])
            {
                current++;
                max = Math.Max(max, current);
            }
            else current = 1;
        }

        return max;
    }
}