using System;
using System.Linq;

/*
public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        return arr
            .OrderBy(x => $"{Convert.ToString(x, 2)}".Count(c => c == '1'))
            .ThenBy(x => x)
            .ToArray();
    }
}
*/

/*
public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        return arr.OrderBy(HammingWeight).ThenBy(x => x).ToArray();
    }

    private static int HammingWeight(int n)
    {
        int count = 0;

        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }
}
*/

public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        Array.Sort(arr, ComparisonHelper());

        return arr;
    }

    private static Comparison<int> ComparisonHelper()
    {
        return (a, b) =>
        {
            int a1BitCount = HammingWeight(a);
            int b1BitCount = HammingWeight(b);

            return a1BitCount < b1BitCount ? -1
                : a1BitCount > b1BitCount ? 1
                : a < b ? -1
                : a > b ? 1 : 0;
        };
    }

    private static int HammingWeight(int n)
    {
        int count = 0;

        while (n != 0)
        {
            count += n & 1;
            n >>= 1;
        }

        return count;
    }
}
