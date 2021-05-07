/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string SortString(string s)
    {
        var chars = s.OrderBy(c => c).ToList();
        var result = new List<char>();

        while (chars.Count > 0)
        {
            var pick = chars.Min();
            result.Add(pick);
            chars.Remove(pick);

            while (chars.Any(c => c > pick))
            {
                var nextPick = chars.First(c => c > pick);
                result.Add(nextPick);
                chars.Remove(nextPick);
                pick = nextPick;
            }

            if (chars.Count == 0)
                break;

            pick = chars.Max();
            result.Add(pick);
            chars.Remove(pick);

            while (chars.Any(c => c < pick))
            {
                var nextPick = chars.Last(c => c < pick);
                result.Add(nextPick);
                chars.Remove(nextPick);
                pick = nextPick;
            }
        }

        return string.Concat(result);
    }
}*/

public class Solution
{
    public string SortString(string s)
    {
        int length = s.Length;
        char[] result = new char[length];
        char[] charCount = new char[26];

        for (int i = 0; i < length; i++)
        {
            char c = s[i];
            charCount[c - 'a']++;
        }

        int j = 0;

        while (j < length)
        {
            for (int i = 0; i < 26; i++)
            {
                if (charCount[i] > 0)
                {
                    result[j] = (char) (i + 'a');
                    charCount[i]--;
                    j++;
                }
            }

            for (int i = 26 - 1; i >= 0; i--)
            {
                if (charCount[i] > 0)
                {
                    result[j] = (char) (i + 'a');
                    charCount[i]--;
                    j++;
                }
            }
        }

        return new string(result);
    }
}