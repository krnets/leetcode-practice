using System.Collections.Generic;
using System.Linq;
using System.Text;

/*public class Solution
{
    public string RemoveDuplicates(string s, int k)
    {
        var stack = new Stack<(char, int)>();
        (char, int) prevTuple = (default, 0);

        foreach (var c in s)
        {
            if (c == prevTuple.Item1)
            {
                prevTuple = stack.Pop();

                int count = prevTuple.Item2;

                if (prevTuple.Item2 < k - 1)
                {
                    prevTuple = (c, count + 1);

                    stack.Push(prevTuple);
                }
                else
                {
                    stack.TryPeek(out prevTuple);
                }
            }
            else
            {
                prevTuple = (c, 1);

                stack.Push(prevTuple);
            }
        }

        return string.Concat(stack
            .Select(x => new string(x.Item1, x.Item2))
            .Reverse());
    }
}*/

public class Solution
{
    public string RemoveDuplicates(string s, int k)
    {
        var sb = new StringBuilder();
        var count = new int[s.Length];

        foreach (char c in s)
        {
            sb.Append(c);

            var last = sb.Length - 1;

            if (last > 0 && sb[last - 1] == sb[last])
                count[last] = count[last - 1] + 1;

            else count[last] = 1;

            if (count[last] == k)
                sb.Remove(sb.Length - k, k);
        }

        return sb.ToString();
    }
}
