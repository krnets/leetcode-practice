/*public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        int sum = 0;
        int n = mat.Length - 1;

        for (int i = 0; i < mat.Length; i++)
        {
            sum += mat[i][i];

            if (i != n - i)
                sum += mat[i][n - i];
        }

        return sum;
    }
}*/

public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        int sum = 0;
        int n = mat.Length - 1;

        for (int i = 0; i < mat.Length; i++)
        {
            sum += mat[i][i];
            sum += mat[i][n - i];
        }

        if (mat.Length % 2 != 0)
            sum -= mat[n / 2][n / 2];

        return sum;
    }
}