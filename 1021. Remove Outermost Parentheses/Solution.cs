/*using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string RemoveOuterParentheses(string S)
    {
        var sb = new StringBuilder();
        var stack = new Stack<char>();
        bool isOuter = false;

        foreach (char c in S)
        {
            if (isOuter == false && c == '(')
            {
                isOuter = true;
                continue;
            }

            if (isOuter && c == '(')
            {
                stack.Push(c);
                sb.Append(c);
            }
            else if (isOuter && c == ')')
            {
                if (stack.Count == 0)
                {
                    isOuter = false;
                }
                else
                {
                    stack.Pop();
                    sb.Append(c);
                }
            }
        }

        return sb.ToString();
    }
}*/

/*using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string RemoveOuterParentheses(string S)
    {
        var sb = new StringBuilder();
        var stack = new Stack<char>();
        bool isOuter = false;

        foreach (char c in S)
        {
            if (isOuter == false && c == '(')
            {
                isOuter = true;
                continue;
            }

            if (isOuter)
            {
                if (c == '(')
                {
                    stack.Push(c);
                    sb.Append(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        isOuter = false;
                    }
                    else
                    {
                        stack.Pop();
                        sb.Append(c);
                    }
                }
            }
        }

        return sb.ToString();
    }
}*/

using System.Text;

public class Solution
{
    public string RemoveOuterParentheses(string S)
    {
        var sb = new StringBuilder();
        int opened = 0;

        foreach (char c in S)
            switch (c)
            {
                case '(':
                {
                    if (opened > 0) sb.Append(c);

                    opened++;

                    break;
                }
                case ')':
                {
                    opened--;

                    if (opened > 0) sb.Append(c);

                    break;
                }
            }

        return sb.ToString();
    }
}