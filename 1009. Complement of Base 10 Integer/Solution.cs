using System;
using System.Linq;

/*public class Solution
{
    public int BitwiseComplement(int n)
    {
        string binary = Convert.ToString(n, 2);
        string flipped = string.Concat(binary.Select(c => c == '0' ? '1' : '0'));

        return Convert.ToInt32(flipped, 2);
    }
}*/

public class Solution
{
    public int BitwiseComplement(int n)
    {
        int bits = 0;
        int mask = 1;
        int x = n;

        while (x != 0)
        {
            x >>= 1;
            bits++;
        }

        for (int i = 1; i < bits; i++)
            mask = (mask << 1) + 1;

        return mask ^ n;
    }
}

/*public class Solution
{
    public int BitwiseComplement(int n)
    {
        int x = n >> 1;
        int mask = 1;

        while (x != 0)
        {
            x >>= 1;
            mask = (mask << 1) + 1;
        }

        return mask ^ n;
    }
}*/