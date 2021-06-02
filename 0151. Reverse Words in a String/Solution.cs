using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

/*
public class Solution
{
    public string ReverseWords(string s)
    {
        var split = Regex.Split(s.Trim(), @"\s+");

        return string.Join(" ", split.Reverse());
    }
}*/

/*public class Solution
{
    public string ReverseWords(string s)
    {
        var words = Regex.Split(s.Trim(), @"\s+");
        Array.Reverse(words);

        return string.Join(" ", words);
    }
}*/


public class Solution
{
    public string ReverseWords(string s)
    {
        var words = new Stack<string>();
        var sb = new StringBuilder();

        foreach (char c in s)
        {
            if (c == ' ')
            {
                if (sb.Length != 0)
                {
                    words.Push(sb.ToString());
                    sb.Clear();
                }
            }
            else sb.Append(c);
        }

        if (sb.Length != 0)
            words.Push(sb.ToString());

        return string.Join(" ", words);
    }
}