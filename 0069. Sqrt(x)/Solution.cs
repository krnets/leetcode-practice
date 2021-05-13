/*public class Solution
{
    public int MySqrt(int x)
    {
        long ans = x;

        while ((ans * ans) > x)
            ans = (ans + (x / ans)) / 2;

        return (int) ans;
    }
}*/

public class Solution
{
    public int MySqrt(int x)
    {
        if (x < 2) return x;

        int lo = 0;
        int hi = x;

        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            long sqr = (long) mid * mid;

            if (sqr == x)
                return mid;

            if (sqr < x)
                lo = mid + 1;
            else hi = mid - 1;
        }

        return hi;
    }
}