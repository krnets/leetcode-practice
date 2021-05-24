/*using System;
using System.Linq;

public class Solution
{
    public int FindComplement(int num)
    {
        var charsFlipped = Convert.ToString(num, 2)
            .SkipWhile(c => c == '0')
            .Select(c => c == '0' ? '1' : '0');

        return Convert.ToInt32(string.Concat(charsFlipped), 2);
    }
}*/

public class Solution
{
    public int FindComplement(int num)
    {
        int mask = 0;
        int x = num;

        while (x != 0)
        {
            x >>= 1;
            mask <<= 1;
            mask++;
        }

        return num ^ mask;
    }
}