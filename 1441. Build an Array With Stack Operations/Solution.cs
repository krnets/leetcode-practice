/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var result = new List<string>();
        var set = target.ToHashSet();
        int end = Math.Min(set.Max(), n);

        for (int i = 1; i <= end; i++)
        {
            result.Add("Push");

            if (!set.Contains(i)) result.Add("Pop");
        }

        return result;
    }
}*/

/*
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var set = target.ToHashSet();

        return Enumerable.Range(1, Math.Min(n, set.Max()))
            .SelectMany(i => set.Contains(i) ? new[] {"Push"} : new[] {"Push", "Pop"}).ToArray();
    }
}

*/
/*public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var set = target.ToHashSet();

        return Enumerable.Range(1, Math.Min(n, set.Max()))
            .SelectMany(i => new[] {"Push"}.Concat(!set.Contains(i) ? new[] {"Pop"} : new string[0])).ToArray();
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var list = new List<string>();

        for (int i = 1, j = 0; i <= n && j < target.Length; i++)
        {
            list.Add("Push");
            if (i == target[j]) j++;
            else list.Add("Pop");
        }

        return list;
    }
}