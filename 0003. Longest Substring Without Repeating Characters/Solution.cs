/*using System;
using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var lastSeenIndex = new Dictionary<char, int>();
        int curStart = 0;
        int ansStart = 0;
        int ansEnd = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (lastSeenIndex.ContainsKey(c))
                curStart = Math.Max(curStart, lastSeenIndex[c] + 1);

            if (ansEnd - ansStart < (i + 1 - curStart))
            {
                ansStart = curStart;
                ansEnd = i + 1;
            }

            lastSeenIndex[c] = i;
        }

        return ansEnd - ansStart;
    }
}*/

using System;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int curStart = 0;
        int longest = 0;
        int[] lastSeenIndex = new int[128];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            curStart = Math.Max(curStart, lastSeenIndex[c]);
            lastSeenIndex[c] = i + 1;
            longest = Math.Max(longest, i - curStart + 1);
        }

        return longest;
    }
}