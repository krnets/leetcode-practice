using System;

/*public class Solution
{
    public bool CheckZeroOnes(string s)
    {
        int max1 = 0;
        int max0 = 0;
        int cur1 = s[0] == '1' ? 1 : 0;
        int cur0 = s[0] == '0' ? 1 : 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                if (s[i - 1] == s[i])
                {
                    cur1++;
                }
                else
                {
                    max1 = Math.Max(max1, cur1);
                    cur1 = 1;
                }
            }
            else
            {
                if (s[i - 1] == s[i])
                {
                    cur0++;
                }
                else
                {
                    max0 = Math.Max(max0, cur0);
                    cur0 = 1;
                }
            }
        }

        return Math.Max(max1, cur1) > Math.Max(max0, cur0);
    }
}*/

public class Solution
{
    public bool CheckZeroOnes(string s)
    {
        int max1 = 0, max0 = 0;
        int cur1 = 0, cur0 = 0;

        foreach (var c in s)
        {
            if (c == '1')
            {
                cur1++;
                max1 = Math.Max(max1, cur1);
                cur0 = 0;
            }
            else
            {
                cur0++;
                max0 = Math.Max(max0, cur0);
                cur1 = 0;
            }
        }

        return Math.Max(max1, cur1) > Math.Max(max0, cur0);
    }
}