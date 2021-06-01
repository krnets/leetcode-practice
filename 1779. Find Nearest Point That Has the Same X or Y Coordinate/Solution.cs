using System;

public class Solution
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        int manhattanDistance = int.MaxValue;
        int ans = -1;

        for (int i = 0; i < points.Length; i++)
        {
            var point = points[i];

            if (point[0] == x || point[1] == y)
            {
                int distance = Math.Abs(point[0] - x) + Math.Abs(point[1] - y);

                if (distance < manhattanDistance)
                {
                    ans = i;
                    manhattanDistance = distance;
                }
            }
        }

        return ans;
    }
}


/*public class Solution
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        int nearest = int.MaxValue;
        int ans = -1;

        for (int i = 0; i < points.Length; i++)
        {
            int[] point = points[i];

            if (point[0] == x || point[1] == y)
            {
                int distance = ManhattanDistance(x, y, point[0], point[1]);

                if (distance < nearest)
                {
                    ans = i;
                    nearest = distance;
                }
            }
        }

        return ans;
    }

    private static int ManhattanDistance(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
    }
}*/