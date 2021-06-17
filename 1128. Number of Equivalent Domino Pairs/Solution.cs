using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        return dominoes.Select(d => (d.Min(), d.Max()))
            .GroupBy(t => t, (_, all) => all.Count())
            .Sum(x => x * (x - 1) / 2);
    }
}*/

/*public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var arr = new int[100];

        foreach (var domino in dominoes)
        {
            int key = domino.Min() * 10 + domino.Max();
            arr[key]++;
        }

        int count = 0;

        foreach (var n in arr) 
            count += n * (n - 1) / 2;

        return count;
    }
}*/

public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        var dict = new Dictionary<int, int>();

        foreach (var domino in dominoes)
        {
            int key = domino.Min() * 10 + domino.Max();

            if (dict.ContainsKey(key))
                dict[key]++;
            else dict[key] = 1;
        }

        int count = 0;

        foreach (var n in dict.Values)
            count += n * (n - 1) / 2;

        return count;
    }
}