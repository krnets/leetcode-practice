using System;
using System.Linq;
using System.Text;

/*public class Solution
{
    public string ReorderSpaces(string text)
    {
        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var lettersLength = string.Concat(words).Length;
        int spaces = text.Length - lettersLength;
        var sb = new StringBuilder();
        int k = words.Length;

        if (k > 1)
        {
            for (int i = 0; i < k - 1; i++)
                sb.Append(words[i])
                    .Append(' ', spaces / (k - 1));

            sb.Append(words[k - 1])
                .Append(' ', spaces % (k - 1));
        }
        else
            sb.Append(words[0])
                .Append(' ', spaces);

        return sb.ToString();
    }
}*/

public class Solution
{
    public string ReorderSpaces(string text)
    {
        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int spaces = text.Count(char.IsWhiteSpace);
        int gap = words.Length == 1 ? 0 : spaces / (words.Length - 1);
        int extra = spaces - gap * (words.Length - 1);

        return string.Join(new string(' ', gap), words) + new string(' ', extra);
    }
}