/*public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var str1 = string.Concat(word1);
        var str2 = string.Concat(word2);

        if (str1.Length != str2.Length) return false;

        for (int i = 0; i < str1.Length; i++)
            if (str1[i] != str2[i])
                return false;

        return true;
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var wordIter1 = Chain(word1).GetEnumerator();
        var wordIter2 = Chain(word2).GetEnumerator();

        bool hasNext1 = wordIter1.MoveNext();
        bool hasNext2 = wordIter2.MoveNext();

        while (hasNext1 && hasNext2)
        {
            if (wordIter1.Current != wordIter2.Current) return false;

            hasNext1 = wordIter1.MoveNext();
            hasNext2 = wordIter2.MoveNext();
        }

        return !hasNext1 && !hasNext2;
    }

    private static IEnumerable<char> Chain(string[] words)
    {
        foreach (string word in words)
        {
            foreach (char c in word)
                yield return c;
        }
    }
}