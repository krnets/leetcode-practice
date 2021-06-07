using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*public class Solution
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        return words.Where(w => IsBijection(w, pattern)).ToArray();
    }

    private bool IsBijection(string word, string pattern)
    {
        var map = new Dictionary<char, char>();
        var set = new HashSet<char>();

        if (word.Length != pattern.Length) return false;

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            if (map.TryGetValue(c, out char p))
            {
                if (p != pattern[i])
                    return false;

                continue;
            }

            if (!set.Add(pattern[i]))
                return false;

            map[c] = pattern[i];
        }

        return true;
    }
}*/

public class Solution
{
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        string cmp = RunningCharCount(pattern);

        return words.Where(w => RunningCharCount(w) == cmp).ToArray();
    }

    private string RunningCharCount(string word)
    {
        var map = new Dictionary<char, int>();
        var sb = new StringBuilder();

        foreach (char c in word)
        {
            if (!map.ContainsKey(c))
                map.Add(c, map.Count);

            sb.Append(map[c]);
        }

        return sb.ToString();
    }
}