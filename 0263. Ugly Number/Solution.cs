/*public class Solution
{
    public bool IsUgly(int n)
    {
        if (n < 1) return false;

        for (int i = 2; i <= 5; i++)
        {
            while (n % i == 0)
            {
                n /= i;
            }
        }

        return n == 1;
    }
}*/

public class Solution
{
    public bool IsUgly(int n)
    {
        if (n < 1) return false;

        while (n % 2 == 0) n /= 2;
        while (n % 3 == 0) n /= 3;
        while (n % 5 == 0) n /= 5;

        return n == 1;
    }
}