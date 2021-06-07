/*using System;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        int correctSum = n * (n + 1) / 2;
        int actualSum = 0;
        int badNum = 0;

        foreach (var x in nums)
        {
            var i = Math.Abs(x);

            nums[i - 1] *= -1;

            if (nums[i - 1] > 0)
            {
                badNum = i;
            }

            actualSum += i;
        }

        return new[] {badNum, correctSum - (actualSum - badNum)};
    }
}*/


public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        var seen = new bool[n];
        int dup = int.MinValue;
        int mis = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            var k = nums[i] - 1;

            if (!seen[k])
                seen[k] = true;

            else dup = k + 1;
        }

        for (int i = 0; i < n; i++)
        {
            if (seen[i])
                continue;

            mis = i + 1;
            break;
        }

        return new[] {dup, mis};
    }
}