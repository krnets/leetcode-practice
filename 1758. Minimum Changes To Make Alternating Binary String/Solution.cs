using System;

public class Solution
{
    public int MinOperations(string s)
    {
        int a = 0, b = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var x = s[i] - '0';

            if (x == i % 2) a++;
            if (x != i % 2) b++;
        }

        return Math.Min(a, b);
    }
}