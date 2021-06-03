/*
using System;
using System.Linq;

public class Solution
{
    public int MinimumDeleteSum(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;
        int[][] dp = new int[m + 1][];
        dp[0] = new int[n + 1];

        for (int i = 1; i <= m; i++)
        {
            dp[i] = new int[n + 1];
            int prevRowFirstItem = dp[i - 1][0];
            dp[i][0] = prevRowFirstItem + s1[i - 1];
        }

        for (int j = 1; j <= n; j++)
        {
            int prevColFirstRow = dp[0][j - 1];
            dp[0][j] = prevColFirstRow + s2[j - 1];
        }

        for (int i = 0; i < dp.Length; i++)
        {
            Console.WriteLine(string.Join(" ", dp[i].Select(x => $"{x}".PadLeft(4))));
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (s1[i - 1] == s2[j - 1])
                {
                    int prevRowPrevCol = dp[i - 1][j - 1];
                    dp[i][j] = prevRowPrevCol;
                }
                else
                {
                    int prevRowSameCol = dp[i - 1][j];
                    int currRowPrevCol = dp[i][j - 1];
                    int choiceA = prevRowSameCol + s1[i - 1];
                    int choiceB = currRowPrevCol + s2[j - 1];
                    dp[i][j] = Math.Min(choiceA, choiceB);
                }
            }
        }

        Console.WriteLine(new string('-', 24));

        for (int i = 0; i < dp.Length; i++)
        {
            Console.WriteLine(string.Join(" ", dp[i].Select(x => $"{x}".PadLeft(4))));
        }

        return dp[m][n];
    }
}
*/


using System;

public class Solution
{
    public int MinimumDeleteSum(string s1, string s2)
    {
        int m = s1.Length + 1;
        int n = s2.Length + 1;
        var dp = new int[m][];
        dp[0] = new int[n];

        for (int i = 1; i < m; i++)
        {
            char c1 = s1[i - 1];
            int prevRowFirstCol = dp[i - 1][0];
            dp[i] = new int[n];
            dp[i][0] = c1 + prevRowFirstCol;
        }

        for (int j = 1; j < n; j++)
        {
            char c2 = s2[j - 1];
            int firstRowPrevCol = dp[0][j - 1];
            dp[0][j] = c2 + firstRowPrevCol;
        }

        for (int i = 1; i < m; i++)
        {
            char c1 = s1[i - 1];

            for (int j = 1; j < n; j++)
            {
                char c2 = s2[j - 1];

                if (c1 == c2)
                {
                    int prevRowPrevCol = dp[i - 1][j - 1];
                    dp[i][j] = prevRowPrevCol;
                }
                else
                {
                    int prevRowSameCol = dp[i - 1][j];
                    int currRowPrevCol = dp[i][j - 1];
                    int choice1 = c1 + prevRowSameCol;
                    int choice2 = c2 + currRowPrevCol;
                    dp[i][j] = Math.Min(choice1, choice2);
                }
            }
        }

        return dp[^1][^1];
    }
}