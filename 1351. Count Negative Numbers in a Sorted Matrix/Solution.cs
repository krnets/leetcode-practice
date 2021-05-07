/*using System.Linq;

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        return grid.SelectMany(row => row).Count(x => x < 0);
    }
}*/

/*public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        int count = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] < 0)
                    count++;
            }
        }

        return count;
    }
}*/

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        int count = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = grid[i].Length - 1; j >= 0; j--)
            {
                if (grid[i][j] < 0)
                    count++;
                else break;
            }
        }

        return count;
    }
}