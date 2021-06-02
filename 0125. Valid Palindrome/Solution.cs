using System.Linq;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var str = string.Concat(s.Where(char.IsLetterOrDigit)).ToLower();

        int n = str.Length - 1;
        int half = str.Length / 2;

        for (int i = 0; i < half; i++)
            if (str[i] != str[n - i])
                return false;

        return true;
    }
}