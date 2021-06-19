using System.Collections.Generic;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dict = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            var cs = s[i];
            var ct = t[i];

            if (dict.ContainsKey(cs))
            {
                if (dict[cs] != ct)
                    return false;
            }
            else
            {
                foreach (var value in dict.Values)
                    if (value == ct)
                        return false;

                dict[cs] = ct;
            }
        }

        return true;
    }
}