using System;
using System.Text;

public class Solution
{
    public string ConvertToBase7(int num)
    {
        if (num == 0)
            return num.ToString();

        var sb = new StringBuilder();
        var sign = Math.Sign(num);
        num = Math.Abs(num);

        while (num != 0)
        {
            sb.Insert(0, num % 7);
            num /= 7;
        }

        if (sign == -1)
            sb.Insert(0, "-");

        return sb.ToString();
    }
}