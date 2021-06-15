using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var triangle = new int[numRows][];

        for (int i = 0; i < numRows; i++)
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

        return triangle;
    }
}