/*using System.Linq;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
    }
}*/

/*public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var charCountS = new char[26];
        var charCountT = new char[26];

        foreach (char c in s) charCountS[c - 'a']++;
        foreach (char c in t) charCountT[c - 'a']++;

        return new string(charCountS) == new string(charCountT);
    }
}*/

/*public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        char[] charCountS = new char[26];
        char[] charCountT = new char[26];

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            charCountS[c - 'a']++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            char c = t[i];
            charCountT[c - 'a']++;
        }

        return new string(charCountS) == new string(charCountT);
    }
}*/

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        char[] charCount = new char[26];

        for (int i = 0; i < s.Length; i++)
        {
            char cs = s[i];
            char ct = t[i];
            charCount[cs - 'a']++;
            charCount[ct - 'a']--;
        }

        for (int i = 0; i < 26; i++)
            if (charCount[i] != 0)
                return false;

        return true;
    }
}