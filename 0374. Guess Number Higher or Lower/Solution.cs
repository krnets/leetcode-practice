/*
  Forward declaration of guess API.
  @param  num   your guess
  @return 	     -1 if num is lower than the guess number
 			      1 if num is higher than the guess number
                otherwise return 0
  int guess(int num);
  */

public class GuessGame
{
    private readonly int number;

    public GuessGame(int n) => number = n;

    public int guess(int num)
    {
        return number < num ? -1 : number > num ? 1 : 0;
    }
}

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int low = 0;
        int high = n;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (guess(mid) == 0)
                return mid;

            if (guess(mid) < 0)
                high = mid;
            else low = mid + 1;
        }

        return low;
    }

    public Solution(int n) : base(n)
    {
    }
}