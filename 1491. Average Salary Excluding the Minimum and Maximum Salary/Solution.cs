using System;
using System.Linq;

public class Solution
{
    public double Average(int[] salary)
    {
        int n = salary.Length;
        int min = salary.Min();
        int max = salary.Max();
        int sum = salary.Sum();

        return (sum - min - max) / (double) (n - 2);
    }
}

/*public class Solution
{
    public double Average(int[] salary)
    {
        int n = salary.Length;
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;

        foreach (var x in salary)
        {
            min = Math.Min(min, x);
            max = Math.Max(max, x);
            sum += x;
        }

        return (sum - min - max) / (double) (n - 2);
    }
}*/