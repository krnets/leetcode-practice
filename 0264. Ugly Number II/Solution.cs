/*public class Solution
{
    public int NthUglyNumber(int n)
    {
        int i = 1;
        int ugly = i;

        while (n > 1)
        {
            i++;

            if (IsUglyNumber(i))
            {
                ugly = i;
                n--;
            }
        }

        return ugly;
    }

    private bool IsUglyNumber(int n)
    {
        while (n % 2 == 0) n /= 2;
        while (n % 3 == 0) n /= 3;
        while (n % 5 == 0) n /= 5;

        return n == 1;
    }
}*/

using System;

public class Solution
{
    public int NthUglyNumber(int n)
    {
        int[] ugly = new int[n];
        ugly[0] = 1;

        int i2 = 0, i3 = 0, i5 = 0;

        int nextUglyNumber = 1;
        int nextMultipleOf2 = 2;
        int nextMultipleOf3 = 3;
        int nextMultipleOf5 = 5;

        for (int i = 1; i < n; i++)
        {
            nextUglyNumber = Math.Min(nextMultipleOf2,
                Math.Min(nextMultipleOf3, nextMultipleOf5));

            ugly[i] = nextUglyNumber;

            if (nextMultipleOf2 == nextUglyNumber)
                nextMultipleOf2 = ugly[++i2] * 2;

            if (nextMultipleOf3 == nextUglyNumber)
                nextMultipleOf3 = ugly[++i3] * 3;

            if (nextMultipleOf5 == nextUglyNumber)
                nextMultipleOf5 = ugly[++i5] * 5;
        }

        return nextUglyNumber;
    }
}