/*using System.Linq;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var charCount = s.GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (charCount[c] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var charCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else charCount[c] = 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (charCount[c] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}*/

/*public class Solution
{
    public int FirstUniqChar(string s)
    {
        var charCount = new int[26];

        foreach (char c in s) charCount[c - 'a']++;

        for (int i = 0; i < s.Length; i++)
        {
            int c = s[i] - 'a';

            if (charCount[c] == 1)
                return i;
        }

        return -1;
    }
}*/

public class Solution
{
    public int FirstUniqChar(string s)
    {
        var charCount = new int[128];

        foreach (char c in s) charCount[c]++;

        for (int i = 0; i < s.Length; i++)
        {
            int c = s[i];

            if (charCount[c] == 1)
                return i;
        }

        return -1;
    }
}