/*using System.Linq;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var end = word1.Length < word2.Length
            ? word2.TakeLast(word2.Length - word1.Length)
            : word1.TakeLast(word1.Length - word2.Length);

        return string.Concat(word1.Zip(word2, (a, b) => $"{a}{b}")) +
               string.Concat(end);
    }
}*/

/*using System;
using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();
        int maxLength = Math.Max(word1.Length, word2.Length);
        int i = 0;

        while (i < maxLength)
        {
            if (i < word1.Length)
                sb.Append(word1[i]);
            if (i < word2.Length)
                sb.Append(word2[i]);
            i++;
        }

        return sb.ToString();
    }
}*/

/*using System;
using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();
        int maxLength = Math.Max(word1.Length, word2.Length);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < word1.Length) sb.Append(word1[i]);
            if (i < word2.Length) sb.Append(word2[i]);
        }

        return sb.ToString();
    }
}*/

using System.Text;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var sb = new StringBuilder();
        int maxLength = word1.Length < word2.Length ? word2.Length : word1.Length;

        for (int i = 0; i < maxLength; i++)
        {
            if (i < word1.Length) sb.Append(word1[i]);
            if (i < word2.Length) sb.Append(word2[i]);
        }

        return sb.ToString();
    }
}

/*public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        string str = string.Empty;
        int maxLength = word1.Length < word2.Length ? word2.Length : word1.Length;

        for (int i = 0; i < maxLength; i++)
        {
            if (i < word1.Length) str += word1[i];
            if (i < word2.Length) str += word2[i];
        }

        return str;
    }
}*/