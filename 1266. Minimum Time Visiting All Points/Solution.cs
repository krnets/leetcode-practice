/*using System;

public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int minTime = 0;

        for (int i = 1; i < points.Length; i++)
        {
            minTime += chebyshevDistance(points[i - 1], points[i]);
        }

        return minTime;
    }

    private int chebyshevDistance(int[] pointA, int[] pointB)
    {
        return Math.Max(Math.Abs(pointA[0] - pointB[0]), Math.Abs(pointA[1] - pointB[1]));
    }
}*/

using System;

public class Solution
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        int minTime = 0;

        for (int i = 1; i < points.Length; i++)
        {
            minTime += chebyshevDistance(points[i - 1], points[i]);
        }

        return minTime;
    }

    private int chebyshevDistance(int[] pointA, int[] pointB)
    {
        int dx = pointA[0] - pointB[0];
        int dy = pointA[1] - pointB[1];

        return Math.Max(Math.Abs(dx), Math.Abs(dy));
    }
}