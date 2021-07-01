using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public IList<int> GrayCode(int n)
    {
        var list = new List<int>();
        int N = (1 << n);

        for (int i = 0; i < N; i++)
        {
            int tmp = i << 1;

            list.Add((tmp ^ i) >> 1);
        }

        return list;
    }
}*/

/*public class Solution
{
    public IList<int> GrayCode(int n)
    {
        return Enumerable.Range(0, 1 << n)
            .Select(i => ((i << 1) ^ i) >> 1)
            .ToList();
    }
}*/

public class Solution
{
    public IList<int> GrayCode(int n)
    {
        int length = 1 << n;
        var result = new int[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = ((i << 1) ^ i) >> 1;
        }

        return result;
    }
}