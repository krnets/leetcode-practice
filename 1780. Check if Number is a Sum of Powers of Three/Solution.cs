/*using System;
using System.Collections.Generic;

public class Solution
{
    public bool CheckPowersOfThree(int n)
    {
        var powersList = new List<int>();
        int power = 1;

        for (int i = 1; i <= n; i++)
        {
            powersList.Add(power);
            power = (int) Math.Pow(3, i);
        }

        for (int i = powersList.Count - 1; n > 0 && i >= 0; i--)
        {
            int p = powersList[i];

            if (n - p == 0) return true;
            if (n - p > 0) n -= p;
        }

        return n == 0;
    }
}*/

/*public class Solution
{
    public bool CheckPowersOfThree(int n)
    {
        int[] powers = new int[15];

        for (int i = 0, p = 1; i < 15; i++, p *= 3)
            powers[i] = p;

        for (int i = powers.Length - 1; n > 0 && i >= 0; i--)
            if (n >= powers[i])
                n -= powers[i];

        return n == 0;
    }
}*/

public class Solution
{
    public bool CheckPowersOfThree(int n)
    {
        while (n > 0)
        {
            if (n % 3 == 2)
                return false;
            n /= 3;
        }

        return true;
    }
}