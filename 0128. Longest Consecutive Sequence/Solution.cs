using System;
using System.Collections.Generic;

/*public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var array = nums.Distinct().OrderBy(x => x).ToArray();
        int count = 1;
        int max = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] - array[i] == 1)
                count++;
            else count = 1;

            max = Math.Max(max, count);
        }

        return array.Length == 1 ? count : max;
    }
}*/

/*public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        int max = 0;
        var set = new HashSet<int>(nums);
        var seqStarts = new List<int>();

        foreach (int x in set)
            if (!set.Contains(x - 1))
                seqStarts.Add(x);

        foreach (int x in seqStarts)
        {
            int count = 1;
            int y = x;

            while (set.Contains(++y))
                count++;

            max = Math.Max(max, count);
        }

        return max;
    }
}*/

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        int max = 0;
        var hashSet = new HashSet<int>(nums);

        foreach (int x in hashSet)
            if (!hashSet.Contains(x - 1))
            {
                int length = 0;

                while (hashSet.Contains(x + length))
                    length++;

                max = Math.Max(max, length);
            }

        return max;
    }
}