/*using System.Linq;

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        return string.Join(" ", s.Split().Take(k));
    }
}*/


/*public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                k--;

                if (k == 0)
                {
                    return s[..i];
                }
            }
        }

        return s;
    }
}*/

using System.Text;

public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        string[] words = s.Split();

        if (words.Length <= k)
            return s;

        var sb = new StringBuilder();

        for (int i = 0; i < k; i++)
        {
            sb.Append(words[i]);

            if (i != k - 1)
                sb.Append(' ');
        }

        return sb.ToString();
    }
}