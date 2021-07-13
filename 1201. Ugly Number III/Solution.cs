public class Solution
{
    // private static long GCD(long a, long b) => b == 0 ? a : GCD(b, a % b);

    private static long GCD(long a, long b)
    {
        while (a != 0)
        {
            var temp = a;
            a = b % a;
            b = temp;
        }

        return b;
    }

    private static long LCM(long a, long b) => (a * b) / GCD(a, b);

    public int NthUglyNumber(int n, int a, int b, int c)
    {
        long ab = LCM(a, b);
        long ac = LCM(a, c);
        long bc = LCM(b, c);
        long abc = LCM(a, bc);

        int low = 1;
        int high = int.MaxValue;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            long total = (mid / a + mid / b + mid / c)
                         - (mid / ab + mid / ac + mid / bc)
                         + (mid / abc);

            if (total < n)
                low = mid + 1;
            else
                high = mid;
        }

        return low;
    }
}