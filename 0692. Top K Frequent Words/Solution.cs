using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        return words
            .GroupBy(w => w)
            .OrderByDescending(g => g.Count())
            .ThenBy(g => g.Key)
            .Take(k)
            .Select(g => g.Key)
            .ToArray();
    }
}