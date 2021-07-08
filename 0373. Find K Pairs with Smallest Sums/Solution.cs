using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        return nums1.SelectMany(_ => nums2,
                (x, y) => (IList<int>) new List<int> {x, y})
            .OrderBy(subList => subList.Sum())
            .Take(k)
            .ToList();
    }
}