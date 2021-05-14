/*using System;

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        double pow = 0.0;

        for (int i = 0; pow < n; i++)
        {
            pow = Math.Pow(3, i);

            if (pow == n)
                return true;
        }

        return false;
    }
}*/

/*using System;

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        return n > 0 && Math.Pow(3, Math.Round(Math.Log(n, 3))) == n;
    }
}*/

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n == 0) return false;

        while (n % 3 == 0)
        {
            n /= 3;
        }
        return n == 1;
    }
}