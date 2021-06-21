public class Solution
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        for (int row = 1; row < matrix.Length; row++)
        {
            for (int col = 1; col < matrix[0].Length; col++)
            {
                int x = matrix[row - 1][col - 1];
                int y = matrix[row][col];

                if (x != y)
                    return false;
            }
        }

        return true;
    }
}