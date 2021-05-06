/*using System.Collections.Generic;

public class Solution
{
    public int MaxDepth(string s)
    {
        var stack = new Stack<char>();
        int depthCount = 0;
        int max = 0;

        foreach (char c in s)
            switch (c)
            {
                case '(':
                    stack.Push(c);
                    depthCount++;
                    max = depthCount > max ? depthCount : max;
                    break;
                case ')' when stack.Peek() == '(':
                    stack.Pop();
                    depthCount--;
                    break;
            }

        return max;
    }
}*/

/*public class Solution
{
    public int MaxDepth(string s)
    {
        int depthCount = 0;
        int max = 0;

        foreach (char c in s)
            switch (c)
            {
                case '(':
                    depthCount++;
                    max = depthCount > max ? depthCount : max;
                    break;
                case ')':
                    depthCount--;
                    break;
            }

        return max;
    }
}*/

/*public class Solution
{
    public int MaxDepth(string s)
    {
        int maxParentheses = 0;
        int count = 0;

        foreach (char c in s)
        {
            if (c == '(') count++;
            else if (c == ')') count--;

            if (count > maxParentheses)
                maxParentheses = count;
        }

        return maxParentheses;
    }
}*/

public class Solution
{
    public int MaxDepth(string s)
    {
        int count = 0;
        int max = 0;

        foreach (char c in s)
            switch (c)
            {
                case '(':
                {
                    count++;

                    if (count > max)
                        max = count;
                    break;
                }
                case ')':
                    count--;
                    break;
            }

        return max;
    }
}