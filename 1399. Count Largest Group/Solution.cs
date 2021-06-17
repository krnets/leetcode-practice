using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int CountLargestGroup(int n)
    {
        var dict = new Dictionary<int, List<int>>();

        for (int i = 1; i <= n; i++)
        {
            var sum = DigitSum(i);

            if (dict.ContainsKey(sum))
                dict[sum].Add(i);

            else dict[sum] = new List<int>() {i};
        }

        int size = int.MinValue;

        foreach (var (key, value) in dict)
        {
            size = Math.Max(size, value.Count);
        }

        return dict.Count(p => p.Value.Count == size);
    }

    private int DigitSum(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}