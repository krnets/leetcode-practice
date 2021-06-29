using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var freq = new Dictionary<int, List<int>>();
        var list = new List<IList<int>>();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            int key = groupSizes[i];

            if (freq.ContainsKey(key))
                freq[key].Add(i);
            else freq[key] = new List<int> {i};
        }

        foreach (int key in freq.Keys)
        {
            var n = freq[key].Count / key;

            for (int i = 0; i < n; i++)
            {
                var subList = freq[key].Skip(key * i).Take(key).ToList();

                list.Add(subList);
            }
        }

        return list;
    }
}