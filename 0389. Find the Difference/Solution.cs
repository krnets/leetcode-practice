/*using System.Linq;

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        char[] sOrdered = s.OrderBy(c => c).ToArray();
        char[] tOrdered = t.OrderBy(c => c).ToArray();

        for (int i = 0; i < tOrdered.Length; i++)
            if (i == sOrdered.Length || sOrdered[i] != tOrdered[i])
                return tOrdered[i];

        return ' ';
    }
}*/

public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        int[] charCount = new int[26];

        foreach (char c in s)
            charCount[c - 'a']++;

        foreach (char c in t)
            if (--charCount[c - 'a'] < 0)
                return c;

        return default;
    }
}