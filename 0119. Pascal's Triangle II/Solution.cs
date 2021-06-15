using System.Collections.Generic;

/*public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var triangle = new int[rowIndex + 1][];

        for (int i = 0; i <= rowIndex; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] += triangle[i - 1][j];
                triangle[i][j] += triangle[i - 1][j - 1];
            }
        }

        return triangle[rowIndex];
    }
}*/

public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var ans = new int[rowIndex + 1];
        ans[0] = 1;

        for (int i = 1; i <= rowIndex; i++)
        {
            for (int j = i; j > 0; j--)
            {
                ans[j] += ans[j - 1];
            }
        }

        return ans;
    }
}