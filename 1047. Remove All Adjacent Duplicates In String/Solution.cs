using System.Text;
using System.Text.RegularExpressions;

/*public class Solution
{
    public string RemoveDuplicates(string s)
    {
        while (Regex.IsMatch(s, @"(.)\1"))
        {
            s = Regex.Replace(s, @"(.)\1", "");
        }

        return s;
    }
}*/

/*public class Solution
{
    public string RemoveDuplicates(string s)
    {
        var pattern = @"(.)\1";

        while (Regex.IsMatch(s, pattern))
        {
            s = Regex.Replace(s, pattern, "");
        }

        return s;
    }
}*/

public class Solution
{
    public string RemoveDuplicates(string s)
    {
        var sb = new StringBuilder();

        foreach (char c in s)
        {
            if (sb.Length == 0 || sb[^1] != c)
            {
                sb.Append(c);
            }
            else
            {
                sb.Remove(sb.Length - 1, 1);
            }
        }

        return sb.ToString();
    }
}