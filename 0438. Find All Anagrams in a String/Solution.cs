/*using System.Collections.Generic;

public class Solution
{
    private static string CharCount(string str)
    {
        char[] array = new char[26];

        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            array[c - 'a']++;
        }

        return new string(array);
    }

    public IList<int> FindAnagrams(string s, string p)
    {
        string charCountP = CharCount(p);
        int pLength = p.Length;
        int n = s.Length - pLength;
        IList<int> indices = new List<int>();

        for (int i = 0; i <= n; i++)
        {
            string sub = s.Substring(i, pLength);

            if (CharCount(sub) == charCountP)
                indices.Add(i);
        }

        return indices;
    }
}*/


/*public class Solution // slow 5%, 5% barely passing tests
{
    public IList<int> FindAnagrams(string s, string p)
    {
        IList<int> indices = new List<int>();
        int pLength = p.Length;

        for (int i = 0; i <= s.Length - pLength; i++)
        {
            string sub = s.Substring(i, pLength);

            if (IsAnagram(p, sub))
                indices.Add(i);
        }

        return indices;
    }

    private bool IsAnagram(string sp, string sq)
    {
        char[] charCount = new char[26];

        for (int i = 0; i < sp.Length; i++)
        {
            char p = sp[i];
            char q = sq[i];
            charCount[p - 'a']++;
            charCount[q - 'a']--;
        }

        for (int i = 0; i < 26; i++)
        {
            if (charCount[i] != 0)
                return false;
        }

        return true;
    }
}*/

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        IList<int> indices = new List<int>();
        int sLength = s.Length;
        int pLength = p.Length;

        if (sLength < pLength)
            return indices;

        int[] sCount = new int[26];
        int[] pCount = new int[26];

        for (int i = 0; i < pLength; i++)
        {
            int c = p[i] - 'a';
            pCount[c]++;
        }

        for (int i = 0; i < sLength; i++)
        {
            sCount[s[i] - 'a']++;

            if (i >= pLength)
                sCount[s[i - pLength] - 'a']--;

            if (sCount.SequenceEqual(pCount))
                indices.Add(i - pLength + 1);
        }

        return indices;
    }
}


/*public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        IList<int> indices = new List<int>();
        int sLength = s.Length;
        int pLength = p.Length;

        if (sLength < pLength)
            return indices;

        char[] sCount = new char[26];
        char[] pCount = new char[26];

        for (int i = 0; i < pLength; i++)
        {
            char c = p[i];
            pCount[c - 'a']++;
        }

        for (int i = 0; i < sLength; i++)
        {
            sCount[s[i] - 'a']++;

            if (i >= pLength)
                sCount[s[i - pLength] - 'a']--;

            if (new string(sCount) == new string(pCount))
                indices.Add(i - pLength + 1);
        }

        return indices;
    }
}*/