public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int rows = mat.Length;
        int cols = mat[0].Length;
        int n = rows * cols;

        if (rows == r || r * c != n)
            return mat;

        int[] flattened = new int[n];
        int pos = 0;

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                flattened[pos] = mat[i][j];
                pos++;
            }
        }

        pos = 0;
        int[][] ans = new int[r][];

        for (int i = 0; i < r; i++)
        {
            ans[i] = new int[c];

            for (int j = 0; j < c; j++)
            {
                ans[i][j] = flattened[pos];
                pos++;
            }
        }

        return ans;
    }
}