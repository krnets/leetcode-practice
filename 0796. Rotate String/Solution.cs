using System.Linq;

public class Solution
{
    public bool RotateString(string s, string goal)
    {
        return s == goal || s.Where((_, i) => s[i..] + s[..i] == goal).Any();
    }
}