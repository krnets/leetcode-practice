using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        int threshold = nums.Length / 3;

        var freqMap = nums.GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

        return nums.Distinct().Where(x => freqMap[x] > threshold).ToArray();
    }
}