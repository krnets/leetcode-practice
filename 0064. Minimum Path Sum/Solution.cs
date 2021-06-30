using System;

public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        var dp = new int[m, n];
        dp[0, 0] = grid[0][0];

        for (int i = 1; i < m; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + grid[i][0];
        }

        for (int j = 1; j < n; j++)
        {
            dp[0, j] = dp[0, j - 1] + grid[0][j];
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                int prevRowSameCol = dp[i - 1, j];
                int sameRowPrevCol = dp[i, j - 1];
                var min = Math.Min(prevRowSameCol, sameRowPrevCol);

                dp[i, j] = grid[i][j] + min;
            }
        }

        return dp[m - 1, n - 1];
    }
}