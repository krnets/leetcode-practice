/*using System.Linq;
using System.Text;

public class Solution
{
    public bool ValidPalindrome(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            var sb = new StringBuilder(s);

            if (IsPalindrome(sb.Remove(i, 1)))
                return true;
        }

        return false;
    }

    private bool IsPalindrome(StringBuilder sb)
    {
        var str = sb.ToString();

        return str.SequenceEqual(str.Reverse());
    }
}*/

/*public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int l = -1, r = s.Length;

        while (++l < --r)
        {
            if (s[l] != s[r])
            {
                return IsPalindromic(s, l, r + 1) || IsPalindromic(s, l - 1, r);
            }
        }

        return true;
    }

    public bool IsPalindromic(string s, int l, int r)
    {
        while (++l < --r)
        {
            if (s[l] != s[r])
            {
                return false;
            }
        }

        return true;
    }
}*/

public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int n = s.Length - 1;
        int half = s.Length / 2;
        int count = 0;

        for (int i = 0; i < half && count < 2; i++)
        {
            if (s[i] == s[n - i - count] ||
                s[i + count] == s[n - i])
                continue;

            count++;
            i--;
        }

        return count < 2;
    }
}