using System;

public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        int ones = 0;
        int flips = 0;

        foreach (var c in s)
        {
            if (c == '1') ones++;
            else flips++;

            flips = Math.Min(flips, ones);
        }

        return flips;
    }
}