using System;
using System.Collections.Generic;

public class Solution
{
    public int MaximalRectangle(char[][] matrix)
    {
        if (matrix.Length == 0 || matrix[0].Length == 0)
            return 0;

        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[] heights = new int[cols];
        int max = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (matrix[row][col] == '0')
                {
                    heights[col] = 0;
                }
                else heights[col]++;
            }

            max = Math.Max(max, LargestRectangleArea(heights));
        }

        return max;
    }

    private int LargestRectangleArea(int[] heights)
    {
        int maxArea = 0;
        int n = heights.Length;
        var stack = new Stack<int>();
        stack.Push(0);

        for (int i = 1; i < n; i++)
        {
            int current = heights[i];

            if (current < heights[stack.Peek()])
            {
                while (stack.Count > 0 && current < heights[stack.Peek()])
                {
                    int x = heights[stack.Pop()];
                    int y = x * (stack.Count > 0 ? i - stack.Peek() - 1 : i);

                    maxArea = Math.Max(maxArea, y);
                }
            }

            stack.Push(i);
        }

        while (stack.Count > 0)
        {
            int x = heights[stack.Pop()];
            int y = x * (stack.Count > 0 ? n - stack.Peek() - 1 : n);

            maxArea = Math.Max(maxArea, y);
        }

        return maxArea;
    }
}