/*
using System;

public class Solution
{
    public int LongestBeautifulSubstring(string word)
    {
        int cnt = 1;
        int len = 1;
        int max = 0;

        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                len++;
            }
            else if (word[i - 1] < word[i])
            {
                cnt++;
                len++;
            }
            else
            {
                len = 1;
                cnt = 1;
            }

            if (cnt == 5)
            {
                max = Math.Max(max, len);
            }
        }

        return max;
    }
}
*/

// return Regex.Matches(word, @"(a+e+i+o+u+)")
//     .Select(m => m.Value.Length)
//     .DefaultIfEmpty(0)
//     .Max();

public class Solution
{
    public int LongestBeautifulSubstring(string word)
    {
        int cnt = 1;
        int len = 1;
        int max = 0;

        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                len++;
            }
            else if (word[i - 1] < word[i])
            {
                cnt++;
                len++;
            }
            else
            {
                len = 1;
                cnt = 1;
            }

            if (cnt == 5 && len > max) 
                max = len;
        }

        return max;
    }
}