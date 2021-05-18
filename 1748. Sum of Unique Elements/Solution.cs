/*using System.Linq;

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        return nums.GroupBy(x => x)
            .Where(g => g.Count() == 1)
            .Select(g => g.Key)
            .Sum();
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        var freq = new Dictionary<int, int>();
        int sum = 0;

        foreach (int num in nums)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else freq[num] = 1;
        }

        // foreach (var (key, _) in freq)
        foreach (var key in freq.Keys)
            if (freq[key] == 1)
                sum += key;

        return sum;
    }
}*/

public class Solution
{
    public int SumOfUnique(int[] nums)
    {
        int[] count = new int[101];
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
            count[nums[i]]++;

        for (int i = 0; i < count.Length; i++)
            if (count[i] == 1)
                sum += i;

        return sum;
    }
}