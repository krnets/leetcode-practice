using System.Collections.Generic;
using System.Linq;

/*

public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var map = arr2
            .Select((x, i) => (x, i))
            .ToDictionary(tuple => tuple.x, tuple => tuple.i);

        return arr1.OrderBy(x => map.TryGetValue(x, out int y) ? y : (x + 1000))
            .ToArray();
    }
}*/

/*public class Solution
{
   public int[] RelativeSortArray(int[] arr1, int[] arr2)
   {
       var map = new Dictionary<int, int>();

       for (int i = 0; i < arr2.Length; i++) 
           map[arr2[i]] = i;

       return arr1.OrderBy(x => map.TryGetValue(x, out int y) ? y : (x + 1000))
           .ToArray();
   }
}*/

public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < arr2.Length; i++)
            map[arr2[i]] = i;

        var first = arr1.Where(x => map.ContainsKey(x))
            .OrderBy(x => map[x]).ToArray();

        var second = arr1.Where(x => !map.ContainsKey(x))
            .OrderBy(x => x).ToArray();

        return first.Concat(second).ToArray();
    }
}

/*public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var arr3 = new int[1001];
        int pos = 0;

        foreach (var x in arr1)
        {
            arr3[x]++;
        }

        foreach (var x in arr2)
        {
            while (arr3[x] > 0)
            {
                arr1[pos] = x;
                arr3[x]--;
                pos++;
            }
        }

        for (var i = 0; i < arr3.Length; i++)
        {
            while (arr3[i] > 0)
            {
                arr1[pos] = i;
                arr3[i]--;
                pos++;
            }
        }

        return arr1;
    }
}*/