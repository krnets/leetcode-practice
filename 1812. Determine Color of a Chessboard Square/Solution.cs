/*public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        var chessBoard = new bool[8, 8];

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
                if ((i % 2 == 0 && j % 2 == 1) || (i % 2 == 1 && j % 2 == 0))
                    chessBoard[i, j] = true;
        }

        int rank = coordinates[1] - '0' - 1;
        int file = coordinates[0] - 'a';

        return chessBoard[rank, file];
    }
}*/

/*public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        int file = coordinates[0] - 'a';
        int rank = coordinates[1] - '0' - 1;

        return (rank % 2 == 0 && file % 2 == 1) || (rank % 2 == 1 && file % 2 == 0);
    }
}*/

public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        return (coordinates[0] - 'a') % 2 != (coordinates[1] - '0' - 1) % 2;
    }
}

/*public class Solution
{
    public bool SquareIsWhite(string coordinates)
    {
        return ((coordinates[0] - 'a') % 2) != ((coordinates[1] - '0' - 1) % 2);
    }
}*/