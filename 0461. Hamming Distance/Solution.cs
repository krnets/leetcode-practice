/*
using System;
using System.Linq;

public class Solution
{
    public int HammingDistance(int x, int y)
    {
        var xBinStr = Convert.ToString(x, 2).PadLeft(32, '0');
        var yBinStr = Convert.ToString(y, 2).PadLeft(32, '0');

        return xBinStr.Zip(yBinStr, (c, d) => c != d).Count(b => b);
    }
}
*/

/*public class Solution
{
    public int HammingDistance(int x, int y)
    {
        int count = 0;
        int n = x ^ y;

        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }
}*/

public class Solution
{
    public int HammingDistance(int x, int y)
    {
        int count = 0;
        int n = x ^ y;

        while (n != 0)
        {
            count += n % 2;
            n /= 2;
        }

        return count;
    }
}