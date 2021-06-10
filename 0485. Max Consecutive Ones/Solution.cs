using System;

/*public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int currMax = nums[0] == 1 ? 1 : 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (nums[i - 1] == nums[i])
                {
                    currMax++;
                }
                else
                {
                    max = Math.Max(max, currMax);
                    currMax = 1;
                }
            }
            else
            {
                max = Math.Max(max, currMax);
                currMax = 0;
            }
        }

        return Math.Max(max, currMax);
    }
}*/

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int ans = 0;
        int i = 0;
        int j = 0;
        int n = nums.Length;

        while (j <= n)
        {
            if (j == n || nums[j] == 0)
            {
                ans = Math.Max(ans, j - i);
                i = j + 1;
            }

            j++;
        }

        return ans;
    }
}