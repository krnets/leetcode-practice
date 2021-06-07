using System;
using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    private static (int DR, int DC)[] Dirs = new (int DR, int DC)[]
    {
        (DR: -1, DC: 0),
        (DR: 1, DC: 0),
        (DR: 0, DC: -1),
        (DR: 0, DC: 1)
    };

    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
    {
        int[][] ret = new int[rows * cols][];
        int i = 0;

        var visited = new HashSet<(int Row, int Col)>();
        var queue = new Queue<(int Row, int Col)>();

        visited.Add((Row: rCenter, Col: cCenter));
        queue.Enqueue((Row: rCenter, Col: cCenter));

        while (queue.Count > 0)
        {
            for (int j = queue.Count; j > 0; j--)
            {
                var curr = queue.Dequeue();

                ret[i] = new[] {curr.Row, curr.Col};
                i++;

                foreach (var dir in Dirs)
                {
                    int nr = dir.DR + curr.Row;
                    int nc = dir.DC + curr.Col;

                    if (nr < 0 || nr >= rows || nc < 0 || nc >= cols)
                        continue;

                    var key = (Row: nr, Col: nc);

                    if (visited.Contains(key))
                        continue;

                    visited.Add(key);
                    queue.Enqueue(key);
                }
            }
        }

        return ret;
    }
}*/


/*public class Solution
{
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
    {
        var map = new Dictionary<int, List<int[]>>();

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)

            {
                var dist = Math.Abs(r - rCenter) + Math.Abs(c - cCenter);

                if (!map.ContainsKey(dist))
                {
                    map[dist] = new List<int[]>();
                }

                map[dist].Add(new[] {r, c});
            }
        }

        var output = new List<int[]>();

        for (int i = 0; i < map.Keys.Count; i++)
        {
            foreach (var distance in map[i])
            {
                output.Add(distance);
            }
        }

        return output.ToArray();
    }
}*/

public class Solution
{
    public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
    {
        var visited = new bool[rows, cols];
        var result = new int[rows * cols][];
        int i = 0;

        var queue = new Queue<int[]>();
        queue.Enqueue(new[] {rCenter, cCenter});

        while (queue.Count > 0)
        {
            int[] cell = queue.Dequeue();
            int r = cell[0];
            int c = cell[1];

            if (r < 0 || r >= rows || c < 0 || c >= cols || visited[r, c])
                continue;

            result[i] = cell;
            visited[r, c] = true;
            i++;

            queue.Enqueue(new[] {r, c - 1});
            queue.Enqueue(new[] {r, c + 1});
            queue.Enqueue(new[] {r - 1, c});
            queue.Enqueue(new[] {r + 1, c});
        }

        return result;
    }
}