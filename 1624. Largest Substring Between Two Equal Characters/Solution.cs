/*
using System;
using System.Collections.Generic;

public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int maxLen = -1;
        var map = new Dictionary<char, (int, int)>();

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (map.ContainsKey(c))
                map[c] = (map[c].Item1, i);
            else map[c] = (i, -1);
        }

        foreach (var (_, (start, end)) in map)
            if (start < end)
                maxLen = Math.Max(maxLen, end - start - 1);

        return maxLen;
    }
}
*/

using System;

/*public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int[] arr = new int[26];
        Array.Fill(arr, -1);
        int max = -1;

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i] - 'a';

            if (arr[c] < 0)
                arr[c] = i;
            else max = Math.Max(max, i - arr[c] - 1);
        }

        return max;
    }
}*/


public class Solution
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        int maxLen = 0;

        for (int i = 0; i < s.Length / 2; i++)
        {
            int end = s.Length - 1;

            while (s[i] != s[end] && i < end)
                end--;

            maxLen = Math.Max(maxLen, end - i);
        }

        return maxLen > 0 ? maxLen - 1 : -1;
    }
}