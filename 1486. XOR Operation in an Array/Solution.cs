/*using System.Linq;

public class Solution
{
    public int XorOperation(int n, int start)
    {
        return Enumerable.Range(0, n)
            .Select(i => start + 2 * i)
            .Aggregate(0, (x, y) => x ^ y);
    }
}*/

/*using System.Linq;

public class Solution
{
    public int XorOperation(int n, int start)
    {
        var arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = start + 2 * i;

        return arr.Aggregate(0, (x, y) => x ^ y);
    }
}*/

/*public class Solution
{
    public int XorOperation(int n, int start)
    {
        var res = 0;

        for (int i = 0; i < n; i++)
            res ^= start + 2 * i;

        return res;
    }
}*/

public class Solution
{
    public int XorOperation(int n, int start)
    {
        var res = start;

        for (int i = 1; i < n; i++)
            res ^= start + 2 * i;

        return res;
    }
}