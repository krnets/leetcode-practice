using System;
using System.Collections.Generic;

public class Solution
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var result = new List<bool>();

        for (int i = 0; i < r.Length; i++)
        {
            var start = l[i];
            var end = r[i] + 1;
            var arr = nums[start..end];

            result.Add(IsArithmetic(arr));
        }

        return result;
    }

    private bool IsArithmetic(int[] arr)
    {
        Array.Sort(arr);
        int distance = arr[1] - arr[0];

        for (int i = 1; i < arr.Length; i++)
            if (arr[i] - arr[i - 1] != distance)
                return false;

        return true;
    }
}