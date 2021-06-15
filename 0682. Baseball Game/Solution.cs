using System.Collections.Generic;

public class Solution
{
    public int CalPoints(string[] ops)
    {
        int sum = 0, x, y;
        var stack = new Stack<int>();

        foreach (var op in ops)
        {
            switch (op)
            {
                case "C":
                    stack.Pop();
                    break;
                case "D":
                {
                    x = stack.Pop();
                    stack.Push(x);
                    stack.Push(2 * x);
                    break;
                }
                case "+":
                {
                    stack.TryPop(out x);
                    stack.TryPop(out y);

                    stack.Push(y);
                    stack.Push(x);
                    stack.Push(x + y);
                    break;
                }
                default:
                    int.TryParse(op, out x);
                    stack.Push(x);
                    break;
            }
        }

        while (stack.Count > 0)
        {
            sum += stack.Pop();
        }

        return sum;
    }
}