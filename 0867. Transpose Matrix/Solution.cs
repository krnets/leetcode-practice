/*public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        var ans = new int[matrix[0].Length][];

        for (int i = 0; i < matrix[0].Length; i++)
        {
            ans[i] = new int[matrix.Length];

            for (int j = 0; j < matrix.Length; j++)
            {
                ans[i][j] = matrix[j][i];
            }
        }

        return ans;
    }
}*/

public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        int rows = matrix[0].Length;
        int cols = matrix.Length;
        var ans = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            ans[i] = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                ans[i][j] = matrix[j][i];
            }
        }

        return ans;
    }
}