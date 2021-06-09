using System;
using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        return mat
            .Select((row, i) => new {Index = i, Soldiers = row.Sum()})
            .ToDictionary(x => x.Index,
                x => x.Soldiers)
            .OrderBy(p => p.Value)
            .Select(p => p.Key)
            .Take(k)
            .ToArray();
    }
}*/

/*public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        return mat
            .Select((row, i) => new {Index = i, Soldiers = row.Sum()})
            .ToDictionary(x => x.Index,
                x => x.Soldiers)
            .OrderBy(p => p.Value)
            .Take(k)
            .Select(p => p.Key)
            .ToArray();
    }
}*/

public class Solution
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        int n = mat.Length;
        var arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            int countSoldiers = 0;

            for (int j = 0; j < mat[i].Length; j++)
                if (mat[i][j] == 1)
                    countSoldiers++;

            arr[i] = new int[] {i, countSoldiers};
        }

        Array.Sort(arr, (a, b) => a[1] - b[1] == 0 ? a[0] - b[0] : a[1] - b[1]);

        var result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = arr[i][0];
        }

        return result;
    }
}