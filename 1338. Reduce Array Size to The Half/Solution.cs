using System;
using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public int MinSetSize(int[] arr)
    {
        var freqMap = arr.GroupBy(x => x)
            .OrderByDescending(g => g.Count())
            .ToDictionary(g => g.Key, g => g.Count());

        int n = arr.Length / 2;
        int count = 0;

        foreach (var key in freqMap.Keys)
        {
            n -= freqMap[key];
            count++;

            if (n <= 0)
                break;
        }

        return count;
    }
}*/

public class Solution
{
    public int MinSetSize(int[] arr)
    {
        var freqMap = new Dictionary<int, int>();

        foreach (int x in arr)
        {
            if (freqMap.ContainsKey(x))
                freqMap[x]++;
            else freqMap[x] = 1;
        }

        int target = arr.Length / 2;
        int maxFreq = 0;
        int count = 0;
        int ans = 0;
        int[] buckets = new int[(int) (10e4 + 1)];

        foreach (int value in freqMap.Values)
        {
            buckets[value]++;
            maxFreq = Math.Max(maxFreq, value);
        }

        while (count < target)
        {
            if (buckets[maxFreq] == 0)
            {
                maxFreq--;
                continue;
            }

            count += maxFreq;
            ans++;
            buckets[maxFreq]--;
        }

        return ans;
    }
}