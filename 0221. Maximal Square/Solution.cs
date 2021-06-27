using System;

public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        if (rows == 0) return 0;

        var dp = new int[rows][];
        int ans = 0;

        for (int row = 0; row < rows; row++)
        {
            dp[row] = new int[cols];

            for (int col = 0; col < cols; col++)
            {
                if (matrix[row][col] == '1')
                {
                    dp[row][col] = 1;

                    if (row > 0 && col > 0)
                    {
                        int prevRow = dp[row - 1][col];
                        int prevCol = dp[row][col - 1];
                        int prevRowCol = dp[row - 1][col - 1];

                        dp[row][col] += Math.Min(prevRowCol, Math.Min(prevCol, prevRow));
                    }
                }

                ans = Math.Max(ans, dp[row][col]);
            }
        }

        return ans * ans;
    }
}