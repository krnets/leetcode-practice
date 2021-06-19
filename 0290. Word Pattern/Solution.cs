using System.Collections.Generic;

/*public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var dict = new Dictionary<char, string>();
        var words = s.Split();

        if (words.Length != pattern.Length)
            return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];
            var word = words[i];

            if (dict.ContainsKey(c) && dict[c] != word ||
                dict.ContainsValue(word) && !dict.ContainsKey(c))
                return false;

            dict[c] = word;
        }

        return true;
    }
}*/

/*public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var dict = new Dictionary<char, string>();
        var set = new HashSet<string>();
        var words = s.Split();

        if (words.Length != pattern.Length)
            return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];
            var word = words[i];

            if (dict.ContainsKey(c))
            {
                if (dict[c] != word)
                    return false;
            }
            else
            {
                if (set.Contains(word))
                    return false;

                set.Add(word);
                dict[c] = word;
            }
        }

        return true;
    }
}*/

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var dict = new Dictionary<char, string>();
        var words = s.Split();

        if (words.Length != pattern.Length)
            return false;

        for (int i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];
            var word = words[i];

            if (dict.ContainsKey(c))
            {
                if (dict[c] != word)
                    return false;
            }
            else
            {
                foreach (var value in dict.Values)
                    if (value == word)
                        return false;

                dict[c] = word;
            }
        }

        return true;
    }
}