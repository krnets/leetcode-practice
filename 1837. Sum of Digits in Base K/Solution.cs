/*using System;
using System.Linq;

public class Solution
{
    public int SumBase(int n, int k)
    {
        int inputBase = 10;
        int numBaseK = (int) $"{n}".Reverse().Select((c, i) => char.GetNumericValue(c) * Math.Pow(inputBase, i)).Sum();
        int sum = 0;

        while (numBaseK > 0)
        {
            sum += numBaseK % k;
            numBaseK /= k;
        }

        return sum;
    }
}*/

/*using System;

public class Solution
{
    public int SumBase(int n, int k)
    {
        int inputBase = 10;
        int numBaseK = 0;
        int sum = 0;
        int i = 0;

        while (n != 0)
        {
            numBaseK += (int) Math.Pow(inputBase, i) * (n % inputBase);
            n /= inputBase;
            i++;
        }

        while (numBaseK > 0)
        {
            sum += numBaseK % k;
            numBaseK /= k;
        }

        return sum;
    }
}*/

public class Solution
{
    public int SumBase(int n, int k)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % k;
            n /= k;
        }

        return sum;
    }
}