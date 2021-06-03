using System.Linq;

/*public class Solution
{
    public int Tribonacci(int n)
    {
        if (n == 0) return 0;
        if (n <= 2) return 1;

        var seq = new int[n];
        seq[1] = 1;
        seq[2] = 1;

        for (int i = 3; i < n; i++)
            seq[i] = seq[i - 3] + seq[i - 2] + seq[i - 1];

        return seq.TakeLast(3).Sum();
    }
}*/

public class Solution
{
    public int Tribonacci(int n)
    {
        if (n == 0) return 0;
        if (n <= 2) return 1;

        var seq = new int[n + 1];
        seq[1] = 1;
        seq[2] = 1;

        for (int i = 3; i <= n; i++)
            seq[i] = seq[i - 3] + seq[i - 2] + seq[i - 1];

        return seq[^1];
    }
}