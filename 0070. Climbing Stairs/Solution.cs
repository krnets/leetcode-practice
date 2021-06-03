/*public class Solution
{
    public int ClimbStairs(int n)
    {
        int a = 0;
        int b = 1;

        while (n > 0)
        {
            (a, b) = (b, a + b);
            n--;
        }

        return b;
    }
}*/

using System.Collections.Generic;

public class Solution
{
    private Dictionary<int, int> memo = new Dictionary<int, int>();

    public int ClimbStairs(int n) => Fibonacci(n + 1);

    private int Fibonacci(int num)
    {
        if (num == 0) return 0;
        if (num == 1) return 1;

        if (memo.ContainsKey(num))
            return memo[num];

        memo[num] = Fibonacci(num - 1) + Fibonacci(num - 2);

        return memo[num];
    }
}