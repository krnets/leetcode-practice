/*using System.Linq;

public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int n = image.Length;

        for (int row = 0; row < n; row++)
        {
            image[row] = image[row].Select(i => i == 0 ? 1 : 0).Reverse().ToArray();
        }

        return image;
    }
}*/


public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int n = image.Length;

        for (int row = 0; row < n; row++)
        {
            int[] reversed = new int[n];

            for (int col = 0; col < n; col++)
            {
                reversed[n - col - 1] = (image[row][col] == 0 ? 1 : 0);
            }

            image[row] = reversed;
        }

        return image;
    }
}


/*public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int n = image.Length;

        for (int row = 0; row < n; row++)
        {
            Array.Reverse(image[row]);

            for (int col = 0; col < n; col++)
            {
                image[row][col]++;
                image[row][col] = image[row][col] % 2;
            }
        }

        return image;
    }
}*/

/*public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int n = image.Length;

        for (int row = 0; row < n; row++)
        {
            int[] reversed = new int[n];

            for (int col = 0; col < n; col++)
            {
                reversed[n - col - 1] = 1 - image[row][col];
            }

            image[row] = reversed;
        }

        return image;
    }
}*/