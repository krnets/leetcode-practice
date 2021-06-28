using System;
using System.Linq;

public class Solution
{
    public double TrimMean(int[] arr)
    {
        Array.Sort(arr);
        int n = arr.Length;
        int i = n / 20;

        return Math.Round(arr[i..(n - i)].Sum() / (double) (n - (2 * i)), 5);
    }
}