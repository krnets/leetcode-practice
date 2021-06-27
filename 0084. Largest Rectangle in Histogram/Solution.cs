using System;
using System.Collections.Generic;

/*public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        var left = new int[n];
        var right = new int[n];
        var stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            if (stack.Count > 0)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();

                left[i] = stack.Count == 0 ? 0 : stack.Peek() + 1;
            }
            else left[i] = 0;

            stack.Push(i);
        }

        stack.Clear();

        for (int i = n - 1; i >= 0; i--)
        {
            if (stack.Count > 0)
            {
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                    stack.Pop();

                right[i] = stack.Count == 0 ? n - 1 : stack.Peek() - 1;
            }
            else right[i] = n - 1;

            stack.Push(i);
        }

        // return Enumerable.Range(0, n)
        //     .Max(i => heights[i] * (right[i] - left[i] + 1));

        int maxArea = 0;

        for (int i = 0; i < n; i++)
        {
            int area = heights[i] * (right[i] - left[i] + 1);

            maxArea = Math.Max(maxArea, area);
        }

        return maxArea;
    }
}*/

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int[] lessFromLeft = new int[n];
        int[] lessFromRight = new int[n];
        lessFromRight[n - 1] = n;
        lessFromLeft[0] = -1;

        for (int i = 1; i < n; i++)
        {
            int pos = i - 1;

            while (pos >= 0 && heights[pos] >= heights[i])
                pos = lessFromLeft[pos];

            lessFromLeft[i] = pos;
        }

        for (int i = n - 2; i >= 0; i--)
        {
            int pos = i + 1;

            while (pos < n && heights[pos] >= heights[i])
                pos = lessFromRight[pos];

            lessFromRight[i] = pos;
        }

        int maxArea = 0;

        for (int i = 0; i < n; i++)
        {
            int area = heights[i] * (lessFromRight[i] - lessFromLeft[i] - 1);

            maxArea = Math.Max(maxArea, area);
        }

        return maxArea;
    }
}