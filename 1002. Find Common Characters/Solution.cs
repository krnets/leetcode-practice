using System;
using System.Collections.Generic;

public class Solution
{
    public IList<string> CommonChars(string[] words)
    {
        var list = new List<string>();
        var charCount = new int[26];
        Array.Fill(charCount, int.MaxValue);

        foreach (var word in words)
        {
            var arr = new int[26];

            foreach (var c in word)
                arr[c - 'a']++;

            for (int i = 0; i < 26; i++)
                charCount[i] = Math.Min(arr[i], charCount[i]);
        }

        for (char c = 'a'; c <= 'z'; c++)
            while (charCount[c - 'a'] > 0)
            {
                list.Add($"{c}");
                charCount[c - 'a']--;
            }

        return list;
    }
}