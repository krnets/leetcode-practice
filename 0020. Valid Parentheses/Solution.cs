using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        var matchingBraces = new Dictionary<char, char>()
        {
            ['('] = ')',
            ['{'] = '}',
            ['['] = ']'
        };
        var stack = new Stack<char>();

        foreach (char c in s)
        {
            if (matchingBraces.ContainsKey(c))
                stack.Push(c);
            else if (stack.Count > 0 && matchingBraces[stack.Peek()] == c)
            {
                stack.Pop();
            }
            else return false;
        }

        return stack.Count == 0;
    }
}