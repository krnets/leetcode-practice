using System;
using System.Collections.Generic;
using System.Linq;

/*public class Solution
{
    public bool HasAllCodes(string s, int k)
    {
        int n = (int) Math.Pow(2, k);
        var binaryCodes = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var code = Convert.ToString(i, 2).PadLeft(k, '0');

            binaryCodes.Add(code);
        }

        foreach (string binaryCode in binaryCodes)
            if (!s.Contains(binaryCode))
                return false;

        return true;
    }
}*/

/*public class Solution
{
    public bool HasAllCodes(string s, int k)
    {
        int n = (int) Math.Pow(2, k);

        for (int i = 0; i < n; i++)
        {
            var code = Convert.ToString(i, 2).PadLeft(k, '0');

            if (!s.Contains(code))
                return false;
        }

        return true;
    }
}*/


public class Solution
{
    public bool HasAllCodes(string s, int k)
    {
        int n = s.Length;
        int size = 1 << k;
        int count = 0;
        int hash = 0;
        int allOnes = ~size;
        bool[] set = new bool[size];
        int[] digits = s.Select(c => c - '0').ToArray();

        for (int i = 0; i < n; i++)
        {
            hash = ((hash << 1) & allOnes) | digits[i];

            if (i >= k - 1 && set[hash] == false)
            {
                set[hash] = true;
                count++;
            }
        }

        return count == size;
    }
}