using System;
using System.Collections.Generic;
using System.Linq;

// O(n^3) time | O(1) space
/*public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length < 2)
            return s;

        var list = new List<string>();

        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                var subStr = s[i..j];

                if (IsPalindrome(subStr))
                    list.Add(subStr);
            }
        }

        return list.OrderBy(x => x.Length).Last();
    }

    private bool IsPalindrome(string str)
    {
        return str.SequenceEqual(str.Reverse());
    }
}*/

/*public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length < 2)
            return s;

        string longest = "";

        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                var subStr = s[i..j];

                if (subStr.Length > longest.Length && IsPalindrome(subStr))
                    longest = subStr;
            }
        }

        return longest;
    }

    private bool IsPalindrome(string str)
    {
        int front = 0;
        int back = str.Length - 1;

        while (front < back)
        {
            if (str[front] != str[back])
                return false;

            front++;
            back--;
        }

        return true;
    }
}*/


// O(n^2) time | O(1) space
/*
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int[] ans = {0, 1};

        for (int i = 1; i < s.Length; i++)
        {
            int[] odd = ExpandPalindromeFrom(s, i - 1, i + 1);
            int[] even = ExpandPalindromeFrom(s, i - 1, i);

            int lenOdd = odd[1] - odd[0];
            int lenEven = even[1] - even[0];
            int[] longest = lenOdd > lenEven ? odd : even;

            if (longest[1] - longest[0] >= ans[1] - ans[0])
                ans = longest;
        }

        return s.Substring(ans[0], ans[1] - ans[0]);
    }

    public static int[] ExpandPalindromeFrom(string s, int front, int back)
    {
        while (front >= 0 && back < s.Length)
        {
            if (s[front] == s[back])
            {
                front--;
                back++;
            }
            else break;
        }

        return new[] {front + 1, back};
    }
}
*/

public class Solution
{
    public string LongestPalindrome(string s)
    {
        int startIndex = 0, maxLen = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int len1 = ExtendPalindromeFrom(s, i, i);
            int len2 = ExtendPalindromeFrom(s, i, i + 1);

            if (maxLen < Math.Max(len1, len2))
            {
                if (len1 > len2)
                    startIndex = (i - len1 / 2);
                else startIndex = (i - len2 / 2 + 1);

                maxLen = Math.Max(len1, len2);
            }
        }

        return s.Substring(startIndex, maxLen);
    }

    private static int ExtendPalindromeFrom(string s, int i, int j)
    {
        while (i >= 0 && j < s.Length)
        {
            if (s[i] == s[j])
            {
                i--;
                j++;
            }
            else break;
        }

        return j - i - 1;
    }
}