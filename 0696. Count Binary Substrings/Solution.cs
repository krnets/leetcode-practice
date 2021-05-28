/*
using System;

public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        int currBlockCount = 1;
        int prevBlockCount = 0;
        int subCount = 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
                currBlockCount++;
            else
            {
                subCount += Math.Min(prevBlockCount, currBlockCount);
                prevBlockCount = currBlockCount;
                currBlockCount = 1;
            }
        }

        subCount += Math.Min(prevBlockCount, currBlockCount);

        return subCount;
    }
}
*/

using System;

public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        int curN = 1;
        int preN = 0;
        int subCount = 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
                curN++;
            else
            {
                subCount += preN < curN ? preN : curN;
                preN = curN;
                curN = 1;
            }
        }

        return subCount + Math.Min(preN, curN);
    }
}