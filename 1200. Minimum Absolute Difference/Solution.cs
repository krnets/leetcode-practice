using System;
using System.Collections.Generic;

/*public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        int min = int.MaxValue;

        for (int i = 1; i < arr.Length; i++)
        {
            min = Math.Min(min, Math.Abs(arr[i] - arr[i - 1]));
        }

        var list = new List<IList<int>>();

        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i] - arr[i - 1]) == min)
            {
                list.Add(new List<int>() {arr[i - 1], arr[i]});
            }
        }

        return list;
    }
}*/

public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        int min = int.MaxValue;

        for (int i = 1; i < arr.Length; i++)
        {
            min = Math.Min(min, arr[i] - arr[i - 1]);
        }

        var list = new List<IList<int>>();

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] == min)
            {
                list.Add(new[] {arr[i - 1], arr[i]});
            }
        }

        return list;
    }
}