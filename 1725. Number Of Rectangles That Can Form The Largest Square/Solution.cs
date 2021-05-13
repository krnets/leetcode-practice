/*using System;
using System.Linq;

public class Solution
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        var map = rectangles.Select(r => Math.Min(r[0], r[1]))
            .GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count());

        return map[map.Keys.Max()];
    }
}*/


using System;

public class Solution
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        int count = 0;
        int maxLen = 0;

        foreach (int[] rect in rectangles)
        {
            int length = rect[0];
            int width = rect[1];
            int cur = Math.Min(length, width);

            if (cur == maxLen)
                count++;
            else if (cur > maxLen)
            {
                maxLen = cur;
                count = 1;
            }
        }

        return count;
    }
}

/*using System;

public class Solution
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        int count = 0;
        int maxLen = 0;

        foreach (int[] rect in rectangles)
        {
            var (length, width) = (rect[0], rect[1]);
            int cur = Math.Min(length, width);

            if (cur == maxLen)
                count++;
            else if (cur > maxLen)
            {
                maxLen = cur;
                count = 1;
            }
        }

        return count;
    }
}*/