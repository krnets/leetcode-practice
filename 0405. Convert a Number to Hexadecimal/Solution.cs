/*using System;

public class Solution
{
    public string ToHex(int num)
    {
        return Convert.ToString(num, 16);
    }
}*/

/*
public class Solution
{
    public string ToHex(int num)
    {
        return $"{num:x}";
    }
}
*/

/*using System.Collections.Generic;

public class Solution
{
    public string ToHex(int num)
    {
        if (num == 0) return "0";

        var hexChars = "0123456789abcdef";
        var digits = new LinkedList<char>();

        for (int i = 0; i < 8 && num != 0; i++)
        {
            digits.AddFirst(hexChars[num & 0xF]);
            num >>= 4;
        }

        return string.Concat(digits);
    }
}*/

using System.Text;

public class Solution
{
    public string ToHex(int num)
    {
        if (num == 0) return "0";

        var hexChars = "0123456789abcdef";
        var sb = new StringBuilder();

        while (num != 0 && sb.Length < 8)
        {
            sb.Insert(0, hexChars[num & 0xF]);
            num >>= 4;
        }

        return sb.ToString();
    }
}