/*using System;

public class Solution
{
    public uint reverseBits(uint n)
    {
        var arr = new uint[32];
        int i = 0;

        while (n != 0)
        {
            arr[i] = n & 1;
            n >>= 1;
            i++;
        }

        return Convert.ToUInt32(string.Concat(arr), 2);
    }
}*/

/*public class Solution
{
    public uint reverseBits(uint n)
    {
        uint ans = 0;

        for (int i = 0; i < 32; i++)
        {
            ans = 2 * ans + n % 2;
            n = n / 2;
        }

        return ans;
    }
}*/

public class Solution
{
    public uint reverseBits(uint n)
    {
        uint ans = 0;

        for (int i = 0; i < 32; i++)
            ans |= ((n >> i) & 1) << (31 - i);

        return ans;
    }
}