/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        var openIndices = new Stack<int>();
        var invalid = new HashSet<int>();

        for (int index = 0; index < s.Length; index++)
        {
            char c = s[index];

            if (c == '(')
                openIndices.Push(index);
            else if (c == ')')
            {
                if (openIndices.TryPop(out _) == false)
                    invalid.Add(index);
            }
        }

        invalid.UnionWith(openIndices);

        return string.Concat(s.Where((_, i) => !invalid.Contains(i)));
    }
}*/

using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        var openIndices = new Stack<int>();
        var invalid = new HashSet<int>();
        var sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
            switch (s[i])
            {
                case '(':
                    openIndices.Push(i);
                    break;
                case ')' when openIndices.TryPop(out _) == false:
                    invalid.Add(i);
                    break;
            }

        invalid.UnionWith(openIndices);

        for (int i = 0; i < s.Length; i++)
            if (!invalid.Contains(i))
                sb.Append(s[i]);

        return sb.ToString();
    }
}