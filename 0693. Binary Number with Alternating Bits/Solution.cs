/*using System;
using System.Linq;

public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        var str = Convert.ToString(n, 2);

        return str.Zip(str.Skip(1), (c, d) => c != d).All(b => b);
    }
}*/

/*public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        if (n < 2) return true;

        int r = n % 2;
        n /= 2;

        while (n != 0)
        {
            if (n % 2 == r)
                return false;

            r = n % 2;
            n /= 2;
        }

        return true;
    }
}*/

public class Solution
{
    public bool HasAlternatingBits(int n)
    {
        int r = n & 1;
        n >>= 1;

        while (n != 0)
        {
            if ((n & 1) == r)
                return false;

            r = n & 1;
            n >>= 1;
        }

        return true;
    }
}