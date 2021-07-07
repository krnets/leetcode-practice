using System;
using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public int FindLHS(int[] nums)
    {
        var freqMap = nums.GroupBy(x => x)
            .OrderBy(g => g.Count())
            .ToDictionary(g => g.Key, g => g.Count());

        return (from key in freqMap.Keys
                where freqMap.ContainsKey(key + 1)
                select freqMap[key] + freqMap[key + 1])
            .Prepend(0).Max();
    }
}*/


/*public class Solution
{
    public int FindLHS(int[] nums)
    {
        var freqMap = nums.GroupBy(x => x)
            .OrderBy(g => g.Count())
            .ToDictionary(g => g.Key, g => g.Count());

        return freqMap.Keys
            .Where(key => freqMap.ContainsKey(key + 1))
            .Select(key => freqMap[key] + freqMap[key + 1])
            .Prepend(0)
            .Max();
    }
}*/

/*public class Solution
{
    public int FindLHS(int[] nums)
    {
        var freqMap = new Dictionary<int, int>();
        int max = 0;

        foreach (int x in nums)
            if (freqMap.ContainsKey(x))
                freqMap[x]++;
            else freqMap[x] = 1;

        foreach (int key in freqMap.Keys)
            if (freqMap.ContainsKey(key + 1))
                max = Math.Max(max, freqMap[key] + freqMap[key + 1]);

        return max;
    }
}*/

/*public class Solution
{
    public int FindLHS(int[] nums)
    {
        Array.Sort(nums);
        int max = 0, left = 0, right = 1;

        while (right < nums.Length)
        {
            int diff = nums[right] - nums[left];

            if (diff == 1)
                max = Math.Max(max, right - left + 1);

            if (diff <= 1)
                right++;
            else left++;
        }

        return max;
    }
}*/

public class Solution
{
    public int FindLHS(int[] nums)
    {
        Array.Sort(nums);
        int max = 0, left = 0, right = 1;

        while (right < nums.Length)
        {
            int diff = nums[right] - nums[left];

            if (diff == 1)
                max = Math.Max(max, right - left + 1);

            if (diff > 1)
                left++;
            else right++;
        }

        return max;
    }
}