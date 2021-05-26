/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var ret = new List<int>(k);
        var sorted = new SortedSet<(int, int)>(ComparerFn());
        var freqMap = nums.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        foreach (var (key, value) in freqMap)
            sorted.Add((key, value));

        while (k > 0)
        {
            var entry = sorted.Max;
            ret.Add(entry.Item1);
            sorted.Remove(entry);
            k--;
        }

        return ret.ToArray();
    }

    private static Comparer<(int, int)> ComparerFn()
    {
        return Comparer<(int, int)>.Create(
            (t1, t2) =>
                t1.Item2 == t2.Item2 ? t1.Item1.CompareTo(t2.Item1) : t1.Item2.CompareTo(t2.Item2));
    }
}*/

/*
using System.Linq;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freqMap = nums
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .ToDictionary(g => g.Key, g => g.Count());

        var result = new int[k];
        int i = 0;

        foreach (int num in freqMap.Keys)
        {
            result[i++] = num;

            if (i == k)
                break;
        }

        return result;
    }
}
*/


/*
using System.Linq;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        return nums
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .ToDictionary(g => g.Key, g => g.Count())
            .Keys
            .Take(k)
            .ToArray();
    }
}
*/


/*
using System.Linq;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        return nums
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .Take(k)
            .Select(g => g.Key)
            .ToArray();
    }
}
*/


using System.Linq;

public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        return nums
            .GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key)
            .Take(k)
            .ToArray();
    }
}