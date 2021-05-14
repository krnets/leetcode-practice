/*using System;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        return n > 0 && Math.Pow(2, Math.Round(Math.Log(n, 2))) == n;
    }
}*/

/*public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        long x = 1;

        while (x < n)
        {
            x <<= 1;
        }

        return x == n;
    }
}*/

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n == 0) return false;

        while (n % 2 == 0)
        {
            n /= 2;
        }

        return n == 1;
    }
}