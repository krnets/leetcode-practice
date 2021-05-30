/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var countMap1 = nums1.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        var countMap2 = nums2.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        var result = new List<int>();

        foreach (int key in countMap1.Keys)
        {
            if (countMap2.ContainsKey(key))
            {
                int min = Math.Min(countMap1[key], countMap2[key]);

                while (min > 0)
                {
                    result.Add(key);
                    min--;
                }
            }
        }

        return result.ToArray();
    }
}*/

/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var countMap = nums1.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        var result = new List<int>();

        for (int i = 0; i < nums2.Length; i++)
        {
            var x = nums2[i];

            if (countMap.ContainsKey(x) && countMap[x] > 0)
            {
                result.Add(x);
                countMap[x]--;
            }
        }

        return result.ToArray();
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            Intersect(nums2, nums1);
        }

        int[] countMap = new int[1001];

        foreach (int num in nums1)
        {
            countMap[num]++;
        }

        var result = new List<int>();

        foreach (int x in nums2)
        {
            if (countMap[x] > 0)
            {
                result.Add(x);
                countMap[x]--;
            }
        }

        return result.ToArray();
    }
}


/*using System;
using System.Collections.Generic;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var list = new List<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);

        int i = 0, j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] > nums2[j])
            {
                j++;
            }
            else if (nums1[i] < nums2[j])
            {
                i++;
            }
            else
            {
                list.Add(nums1[i]);
                i++;
                j++;
            }
        }

        return list.ToArray();
    }
}*/