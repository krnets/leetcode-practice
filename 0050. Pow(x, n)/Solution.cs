/*public class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0) return 1;

        double half = MyPow(x, n / 2);

        return half * (n % 2 == 0
            ? half
            : n > 0
                ? half * x
                : half / x);
    }
}*/

public class Solution
{
    public double MyPow(double x, int n)
    {
        long N = n;

        if (N < 0)
        {
            x = 1 / x;
            N = -N;
        }

        double ans = 1;
        double product = x;

        for (long i = N; i > 0; i /= 2)
        {
            if (i % 2 == 1)
                ans *= product;

            product *= product;
        }

        return ans;
    }
}