/*using System;

public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int[] result = new int[s.Length];
        Array.Fill(result, int.MaxValue);
        int left, right, lastStart = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                left = i;
                right = i + 1;
                while (left >= lastStart)
                {
                    result[left] = Math.Min(result[left], i - left);
                    left--;
                }

                while (right < s.Length && s[right] != c)
                {
                    result[right] = right - i;
                    right++;
                }

                lastStart = i + 1;
            }
        }

        return result;
    }
}*/

/*
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int[] result = new int[s.Length];
        var cIndices = new List<int>();

        for (int i = 0; i < s.Length; i++)
            if (s[i] == c)
                cIndices.Add(i);

        for (int i = 0; i < result.Length; i++)
            result[i] = cIndices.Select(x => Math.Abs(x - i)).Min();

        return result;
    }
}
*/

using System;

public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int[] ans = new int[s.Length];

        for (int i = 0; i < ans.Length; i++)
        {
            int leftMax = s[..i].LastIndexOf(c);
            int rightMax = s[i..].IndexOf(c);

            if (leftMax > -1 && rightMax > -1)
                ans[i] = Math.Min(i - leftMax, rightMax);

            else if (leftMax > -1)
                ans[i] = i - leftMax;

            else ans[i] = rightMax;
        }

        return ans;
    }
}
