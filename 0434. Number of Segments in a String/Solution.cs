using System;
using System.Text.RegularExpressions;

/*
public class Solution
{
    public int CountSegments(string s)
    {
        return Regex.Matches(s, @"[\w!@#$%^&*()_+-=',.:]+").Count;
    }
}
*/

/*
public class Solution
{
    public int CountSegments(string s)
    {
        return Regex.Matches(s, @"[\w!@#$%^&*()_+-=',]+").Count;
    }
}
*/

public class Solution
{
    public int CountSegments(string s)
    {
        int count = 1;

        for (int i = 1; i < s.Trim().Length; i++)
            if (char.IsWhiteSpace(s[i]) && !char.IsWhiteSpace(s[i - 1]))
                count++;

        return string.IsNullOrWhiteSpace(s) ? 0 : count;
    }
}

/*
public class Solution
{
    public int CountSegments(string s)
    {
        return s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
*/
