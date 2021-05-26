/*using System.Linq;

public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        var freqMap = nums.GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

        return nums.OrderBy(x => freqMap[x])
            .ThenByDescending(x => x)
            .ToArray();
    }
}*/

using System.Linq;

public class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        return nums.GroupBy(x => x)
            .OrderBy(g => g.Count())
            .ThenByDescending(g => g.Key)
            .SelectMany(g => Enumerable.Repeat(g.Key, g.Count()))
            .ToArray();
    }
}