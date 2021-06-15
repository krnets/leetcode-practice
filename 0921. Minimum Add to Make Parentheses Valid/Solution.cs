/*using System.Text.RegularExpressions;

public class Solution
{
    public int MinAddToMakeValid(string s)
    {
        var pattern = @"\(\)";

        while (Regex.IsMatch(s, pattern))
        {
            s = Regex.Replace(s, pattern, "");
        }

        return s.Length;
    }
}*/

public class Solution
{
    public int MinAddToMakeValid(string s)
    {
        int left = 0, right = 0;

        foreach (char c in s)
        {
            if (c == '(')
                right++;
            else if (right > 0)
                right--;
            else left++;
        }

        return left + right;
    }
}