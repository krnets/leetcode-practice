/*using System.Linq;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var mapOccurences = arr.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        return mapOccurences.Values.Distinct().Count() == mapOccurences.Count;
    }
}*/

/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var map = new Dictionary<int, int>();

        foreach (int x in arr)
        {
            if (map.ContainsKey(x))
                map[x]++;
            else map[x] = 1;
        }

        var set = map.Values.ToHashSet();

        return set.Count == map.Count;
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var map = new Dictionary<int, int>();

        foreach (int x in arr)
        {
            if (map.ContainsKey(x))
                map[x]++;
            else map[x] = 1;
        }

        var set = new HashSet<int>(map.Values);

        return set.Count == map.Count;
    }
}


/*public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var map = new Dictionary<int, int>();

        foreach (int x in arr)
        {
            if (map.ContainsKey(x))
                map[x]++;
            else map[x] = 1;
        }

        var set = new HashSet<int>();

        foreach (int occur in map.Values)
        {
            if (set.Contains(occur))
                return false;

            set.Add(occur);
        }

        return true;
    }
}*/