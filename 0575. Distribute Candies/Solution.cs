using System;
using System.Linq;

public class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        return Math.Min(candyType.Length / 2, candyType.Distinct().Count());
    }
}