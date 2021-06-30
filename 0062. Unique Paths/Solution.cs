using System;
using System.Collections.Generic;
using System.Numerics;

/*public class Solution
{
    public int UniquePaths(int m, int n)
    {
        m--;
        n--;

        if (m == 0 || n == 0)
            return 1;

        long p = m + n;
        long d1 = 1;
        long d2 = 1;

        for (long k = Math.Min(m, n); k > 0; k--)
        {
            d1 *= k;
            d2 *= (p + 1 - k);
        }

        return (int) (d2 / d1);
    }
}*/

/*public class Solution
{
    public int UniquePaths(int m, int n)
    {
        var grid = new int[m, n];
        grid[0, 0] = 1;

        for (int i = 0; i < m; i++)
        {
            int j = (i == 0) ? 1 : 0;

            while (j < n)
            {
                int x = 0, y = 0;

                if (j > 0) x = grid[i, j - 1];
                if (i > 0) y = grid[i - 1, j];

                grid[i, j] = x + y;
                j++;
            }
        }

        return grid[m - 1, n - 1];
    }
}*/

/*public class Solution
{
    public int UniquePaths(int m, int n)
    {
        var grid = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 || j == 0)
                    grid[i, j] = 1;
                else
                {
                    int x = grid[i, j - 1];
                    int y = grid[i - 1, j];

                    grid[i, j] = x + y;
                }
            }
        }

        return grid[m - 1, n - 1];
    }
}*/

/*public class Solution
{
    public int UniquePaths(int m, int n)
    {
        return (int) (Factorial(m + n - 2) / (Factorial(m - 1) * Factorial(n - 1)));
    }

    private BigInteger Factorial(BigInteger n)
    {
        return n <= 1 ? 1 : n * Factorial(n - 1);
    }
}*/

public class Solution
{
    public int UniquePaths(int m, int n)
    {
        var grid = new int[m, n];

        for (int i = 0; i < m; i++)
            grid[i, 0] = 1;

        for (int j = 0; j < n; j++)
            grid[0, j] = 1;

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
                grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
        }

        return grid[m - 1, n - 1];
    }
}

/*public class Solution
{
    int paths;

    public int UniquePaths(int m, int n)
    {
        Dfs(m, 0, n, 0);

        return paths;
    }

    private void Dfs(int m, int row, int n, int col)
    {
        if (col == m || row == n)
            return;

        if (col == m - 1 && row == n - 1)
            paths++;

        Dfs(m, row, n, col + 1);
        Dfs(m, row + 1, n, col);
    }
}*/