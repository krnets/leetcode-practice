/*public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n == 0) return false;

        while (n % 4 == 0)
        {
            n /= 4;
        }

        return n == 1;
    }
}*/

using System;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        return n > 0 && Math.Pow(4, Math.Round(Math.Log(n, 4))) == n;
    }
}