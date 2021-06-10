using System;

public class Solution
{
    public int MaxPower(string s)
    {
        int max = 1;
        int currMax = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i - 1] == s[i])
            {
                currMax++;
            }
            else
            {
                max = Math.Max(max, currMax);
                currMax = 1;
            }
        }

        return Math.Max(max, currMax);
    }
}