/*using System;
using System.Linq;

public class Solution
{
    public int[] CountBits(int num)
    {
        return Enumerable.Range(0, num + 1)
            .Select(i => Convert.ToString(i, 2).Count(c => c == '1'))
            .ToArray();
    }
}*/

/*public class Solution
{
    public int[] CountBits(int num)
    {
        int[] ans = new int[num + 1];

        for (int i = 1; i <= num; i++)
        {
            ans[i] = ans[i >> 1] + (i & 1);
        }

        return ans;
    }
}*/

public class Solution
{
    public int[] CountBits(int num)
    {
        int[] ans = new int[num + 1];

        for (int i = 1; i <= num; i++)
        {
            ans[i] = ans[i & (i - 1)] + 1;
        }

        return ans;
    }
}