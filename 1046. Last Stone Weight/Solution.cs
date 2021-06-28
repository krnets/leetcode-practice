using System;
using System.Linq;

/*public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        Array.Sort(stones, (a, b) => b - a);

        var list = stones.ToList();

        while (list.Count > 1)
        {
            var a = list[0];
            var b = list[1];
            int c;

            if (a < b)
                c = b - a;
            else c = a - b;

            list = list.Skip(2).Append(c).OrderByDescending(x => x).ToList();
        }

        return list.First();
    }
}*/

public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        Array.Sort(stones, (a, b) => b - a);
        var list = stones.ToList();

        while (list.Count > 1)
        {
            int a = list[0];
            int b = list[1];
            int c = Math.Abs(a - b);
            list.RemoveRange(0, 2);

            if (list.Count == 0)
            {
                list.Add(c);
                break;
            }

            if (c == 0)
                continue;

            int i = 0;

            while (i < list.Count && list[i] > c)
                i++;

            if (i < list.Count)
                list.Insert(i, c);
            else list.Add(c);
        }

        return list.First();
    }
}