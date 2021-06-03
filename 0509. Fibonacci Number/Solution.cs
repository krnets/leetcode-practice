/*
public class Solution
{
    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        return Fib(n - 1) + Fib(n - 2);
    }
}
*/

/*public class Solution
{
    public int Fib(int n)
    {
        int a = 0;
        int b = 1;

        while (n > 0)
        {
            (a, b) = (b, a + b);
            n--;
        }

        return a;
    }
}*/

using System.Collections.Generic;

public class Solution
{
    private Dictionary<int, int> memo = new Dictionary<int, int>();

    public int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        if (memo.ContainsKey(n))
            return memo[n];

        memo[n] = Fib(n - 1) + Fib(n - 2);

        return memo[n];
    }
}