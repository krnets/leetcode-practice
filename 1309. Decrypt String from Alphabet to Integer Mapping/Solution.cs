/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string FreqAlphabets(string s)
    {
        var stack = new Stack<string>();

        for (int i = s.Length - 1; i >= 0; i--)
            if (s[i] == '#')
            {
                stack.Push(s.Substring(i - 2, 2));
                i -= 2;
            }
            else stack.Push(s.Substring(i, 1));


        return string.Concat(stack.Select(x => (char) ('a' + int.Parse(x) - 1)));
    }
}*/

using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string FreqAlphabets(string s)
    {
        var stack = new Stack<int>();

        for (int i = s.Length - 1; i >= 0; i--)
            if (s[i] == '#')
            {
                stack.Push(int.Parse(s.Substring(i - 2, 2)));
                i -= 2;
            }
            else stack.Push(int.Parse(s.Substring(i, 1)));


        return string.Concat(stack.Select(x => (char) (x - 1 + 'a')));
    }
}