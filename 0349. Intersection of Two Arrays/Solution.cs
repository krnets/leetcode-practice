/*using System.Linq;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        return nums1.Intersect(nums2).ToArray();
    }
}*/

/*using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>();

        foreach (var x in nums2)
            if (nums1.Contains(x))
                set.Add(x);

        return set.ToArray();
    }
}*/

/*using System.Collections.Generic;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            Intersection(nums2, nums1);

        var set = new HashSet<int>();
        var list = new List<int>();

        foreach (var x in nums1) set.Add(x);

        foreach (var x in nums2)
        {
            if (set.Contains(x))
            {
                list.Add(x);
                set.Remove(x);
            }
        }

        return list.ToArray();
    }
}*/

/*using System;
using System.Collections.Generic;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
            Intersection(nums2, nums1);

        Array.Sort(nums1);
        var set = new HashSet<int>();

        foreach (var x in nums2)
        {
            if (BinarySearch(nums1, x))
            {
                set.Add(x);
            }
        }

        var result = new int[set.Count];
        int i = 0;

        foreach (int x in set)
        {
            result[i] = x;
            i++;
        }

        return result;
    }

    private bool BinarySearch(int[] arr, int x)
    {
        int lo = 0;
        int hi = arr.Length - 1;

        while (lo <= hi)
        {
            int mid = (lo + hi) / 2;

            if (arr[mid] == x) return true;

            if (x < arr[mid])
            {
                hi = mid - 1;
            }
            else lo = mid + 1;
        }

        return false;
    }
}*/

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        int[] array = new int[1001];

        foreach (int x in nums1)
            if (array[x] == 0)
                array[x] = 1;

        int count = 0;

        foreach (var x in nums2)
            if (array[x] == 1)
            {
                array[x] = 2;
                count++;
            }

        var result = new int[count];
        int pos = 0;

        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == 2)
            {
                result[pos] = i;
                pos++;
            }
        }

        return result;
    }
}