/*using System.Linq;

public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        int n = nums.Length / 2;
        var elemCount = nums.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

        foreach (var (key, value) in elemCount)
            if (value == n)
                return key;

        return 0;
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!set.Contains(num))
                set.Add(num);
            else return num;
        }

        return -1;
    }
}