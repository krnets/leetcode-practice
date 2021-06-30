/*public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        var grid = new int[m, n];
        bool blocked = false;

        for (int i = 0; i < m; i++)
        {
            if (obstacleGrid[i][0] == 1)
                blocked = true;

            grid[i, 0] = (blocked ? 0 : 1);
        }

        blocked = false;

        for (int j = 0; j < n; j++)
        {
            if (obstacleGrid[0][j] == 1)
                blocked = true;

            grid[0, j] = (blocked ? 0 : 1);
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1)
                    grid[i, j] = 0;
                else
                {
                    grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
                }
            }
        }

        return grid[m - 1, n - 1];
    }
}*/

public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int n = obstacleGrid[0].Length;
        var dp = new int[n];
        dp[0] = 1;

        foreach (int[] row in obstacleGrid)
        {
            for (int j = 0; j < n; j++)
            {
                if (row[j] == 1)
                    dp[j] = 0;

                else if (j > 0)
                    dp[j] += dp[j - 1];
            }
        }

        return dp[^1];
    }
}