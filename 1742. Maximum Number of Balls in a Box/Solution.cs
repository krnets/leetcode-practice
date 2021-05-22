using System;
using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public int CountBalls(int lowLimit, int highLimit)
    {
        var sumCount = new Dictionary<int, int>();

        for (int i = lowLimit; i <= highLimit; i++)
        {
            int digitSum = SumDigits(i);

            if (sumCount.ContainsKey(digitSum))
                sumCount[digitSum]++;
            else sumCount.Add(digitSum, 1);
        }

        return sumCount.Values.Max();
    }

    private int SumDigits(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}*/

public class Solution
{
    public int CountBalls(int lowLimit, int highLimit)
    {
        int[] sumCount = new int[50];
        int max = 0;

        for (int i = lowLimit; i <= highLimit; i++)
        {
            int digitSum = SumDigits(i);
            sumCount[digitSum]++;
        }

        for (int i = 0; i < sumCount.Length; i++)
        {
            max = Math.Max(max, sumCount[i]);
        }

        return max;
    }

    private int SumDigits(int n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}