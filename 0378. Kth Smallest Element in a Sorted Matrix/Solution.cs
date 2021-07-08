using System;
using System.Collections.Generic;
using System.Linq;

/*
public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        int n = matrix.Length;
        var list = new List<int>();

        for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            list.Add(matrix[i][j]);

        return list.OrderBy(x => x).ElementAt(k - 1);
    }
}
*/

/*public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        int n = matrix.Length;
        int smallest = 0;

        var comparer = new DuplicateKeyComparer<int>();
        var sortedList = new SortedList<int, (int, int)>(comparer);

        for (int i = 0; i < n; i++)
            sortedList.Add(matrix[i][0], (i, 0));

        while (k-- > 0)
        {
            smallest = sortedList.First().Key;
            int x = sortedList.First().Value.Item1;
            int y = sortedList.First().Value.Item2;

            sortedList.RemoveAt(0);

            if (y < (n - 1))
                sortedList.Add(matrix[x][y + 1], (x, y + 1));
        }

        return smallest;
    }

    public class DuplicateKeyComparer<TKey> : IComparer<TKey> where TKey : IComparable
    {
        public int Compare(TKey x, TKey y)
        {
            if (x == null || y == null)
                return 1;

            int result = x.CompareTo(y);

            return result == 0 ? 1 : result;
        }
    }
}*/

/*public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        if (matrix.Length == 0) return 0;

        int n = matrix.Length;
        int ans = 0;
        var sortedSet = new SortedSet<(int, int, int)>();

        for (int i = 0; i < n; i++)
        {
            int firstElem = matrix[i][0];
            var t = (firstElem, i, 0);
            sortedSet.Add(t);
        }

        while (k > 0)
        {
            var tuple = sortedSet.Min;
            var (key, row, col) = tuple;
            ans = key;

            sortedSet.Remove(tuple);

            if (col < (n - 1))
            {
                int index = matrix[row][col + 1];
                var t = (index, row, col + 1);
                sortedSet.Add(t);
            }

            k--;
        }

        return ans;
    }
}*/

public class Solution
{
    public int KthSmallest(int[][] matrix, int k)
    {
        return matrix.SelectMany(x => x).OrderBy(x => x).ElementAt(k - 1);
    }
}