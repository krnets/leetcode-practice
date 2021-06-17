public class Solution
{
    public int NumSpecial(int[][] mat)
    {
        int count = 0;

        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
                if (mat[i][j] == 1 && IsSpecial(mat, i, j))
                    count++;
        }

        return count;
    }

    private bool IsSpecial(int[][] mat, int row, int col)
    {
        for (int i = 0; i < mat.Length; i++)
            if (i != row && mat[i][col] == 1)
                return false;

        for (int j = 0; j < mat[row].Length; j++)
            if (j != col && mat[row][j] == 1)
                return false;

        return true;
    }
}