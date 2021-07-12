/*public class Solution
{
    public bool IsHappy(int n)
    {
        while (n > 9)
        {
            int sum = 0;
            int x = n;

            while (x > 0)
            {
                int digit = x % 10;
                sum += digit * digit;
                x /= 10;
            }

            n = sum;
        }

        return n == 1 || n == 7;
    }
}*/

/*public class Solution
{
    public bool IsHappy(int n)
    {
        if (n == 1 || n == 7) return true;
        if (n < 10) return false;

        int m = 0;

        while (n > 0)
        {
            int digit = n % 10;
            m += digit * digit;
            n /= 10;
        }

        return IsHappy(m);
    }
}*/

public class Solution
{
    public bool IsHappy(int n)
    {
        int slow = n;
        int fast = n;

        do
        {
            slow = digitSquareSum(slow);
            fast = digitSquareSum(fast);
            fast = digitSquareSum(fast);
        } while (slow != fast);

        return slow == 1;
    }

    private int digitSquareSum(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}