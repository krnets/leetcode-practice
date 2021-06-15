using System.Collections.Generic;

public class Solution
{
    public int MinOperations(string[] logs)
    {
        var stack = new Stack<string>();

        foreach (var log in logs)
        {
            switch (log)
            {
                case "../":
                    stack.TryPop(out _);
                    break;
                case "./":
                    break;
                default:
                    stack.Push(log);
                    break;
            }
        }

        return stack.Count;
    }
}