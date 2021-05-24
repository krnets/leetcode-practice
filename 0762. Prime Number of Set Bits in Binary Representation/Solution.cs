using System.Collections.Generic;

public class Solution
{
    private static List<int> primes = new List<int> {2, 3, 5, 7, 11, 13, 17, 19};

    public int CountPrimeSetBits(int left, int right)
    {
        int count = 0;

        for (int i = left; i <= right; i++)
        {
            int setBitCount = CountSetBits(i);

            if (primes.Contains(setBitCount))
                count++;
        }

        return count;
    }

    private int CountSetBits(int n)
    {
        int count = 0;

        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }
}