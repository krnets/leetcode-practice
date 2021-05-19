/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int FindLucky(int[] arr)
    {
        int lucky = -1;
        var freqMap = new Dictionary<int, int>();

        foreach (int item in arr)
            if (freqMap.ContainsKey(item))
                freqMap[item]++;
            else freqMap[item] = 1;

        foreach (int key in freqMap.Keys.OrderBy(x => x))
            if (key == freqMap[key])
                lucky = key;

        return lucky;
    }
}*/

public class Solution
{
    public int FindLucky(int[] arr)
    {
        var freq = new int[501];

        foreach (int x in arr)
            freq[x]++;

        for (int i = freq.Length - 1; i > 0; i--)
            if (freq[i] == i)
                return i;

        return -1;
    }
}