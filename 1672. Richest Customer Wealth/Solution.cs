/*using System.Linq;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        return accounts.Select(row => row.Sum()).Max();
    }
}*/

using System;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            max = sum > max ? sum : max;
            // max = Math.Max(sum, max);
        }

        return max;
    }
}