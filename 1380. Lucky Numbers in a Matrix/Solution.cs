/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var rowMins = new List<int>();
        var colMaxs = new List<int>();

        for (int col = 0; col < matrix[0].Length; col++)
        {
            int colMax = int.MinValue;

            foreach (var row in matrix)
            {
                rowMins.Add(row.Min());
                colMax = Math.Max(colMax, row[col]);
            }

            colMaxs.Add(colMax);
        }

        return rowMins.Intersect(colMaxs).ToList();
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var list = new List<int>();

        foreach (var row in matrix)
        {
            int rowMin = row.Min();
            int colMax = 0;
            int c = Array.IndexOf(row, rowMin);

            foreach (var rowIter in matrix)
                colMax = Math.Max(colMax, rowIter[c]);

            if (rowMin == colMax)
                list.Add(rowMin);
        }

        return list;
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        return (from row in matrix
                let rowMin = row.Min()
                let c = Array.IndexOf(row, rowMin)
                let colMax = matrix.Select(row => row[c]).Prepend(0).Max()
                where rowMin == colMax
                select rowMin)
            .ToList();
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var list = new List<int>();

        foreach (var row in matrix)
        {
            int rowMin = row.Min();
            int c = Array.IndexOf(row, rowMin);
            int colMax = matrix.Select(r => r[c]).Prepend(0).Max();

            if (rowMin == colMax) list.Add(rowMin);
        }

        return list;
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var list = new List<int>();

        foreach (var row in matrix)
        {
            int rowMin = row.Min();
            int c = Array.IndexOf(row, rowMin);
            int colMax = matrix.Select(r => r[c]).Max();

            if (rowMin == colMax) list.Add(rowMin);
        }

        return list;
    }
}*/


using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var list = new List<int>();

        for (int i = 0; i < matrix.Length; i++)
        {
            var row = matrix[i];
            int rowMin = row.Min();
            int c = Array.IndexOf(row, rowMin);
            int colMax = matrix.Max(r => r[c]);

            if (rowMin == colMax)
                list.Add(rowMin);
        }

        return list;
    }
}