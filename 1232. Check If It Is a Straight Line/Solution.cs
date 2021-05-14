public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        int xFirstDiff = coordinates[1][0] - coordinates[0][0];
        int yFirstDiff = coordinates[1][1] - coordinates[0][1];

        for (int i = 1; i < coordinates.Length - 1; i++)
        {
            int currX = coordinates[i][0];
            int currY = coordinates[i][1];

            int nextX = coordinates[i + 1][0];
            int nextY = coordinates[i + 1][1];

            if (xFirstDiff * (nextY - currY) != yFirstDiff * (nextX - currX))
                return false;
        }

        return true;
    }
}