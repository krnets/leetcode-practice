/*using System.Linq;
using System.Numerics;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        return (BigInteger.Parse(string.Concat(digits)) + 1).ToString().Select(c => c - '0').ToArray();
    }
}*/

/*using System;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;

                if (i == 0)
                {
                    var ret = new int[digits.Length + 1];
                    ret[0] = 1;
                    Array.Copy(digits, 0, ret, 1, digits.Length);

                    return ret;
                }
            }
            else
            {
                digits[i]++;
                break;
            }
        }

        return digits;
    }
}*/


using System;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                break;
            }

            digits[i] = 0;

            if (i == 0)
            {
                var ret = new int[digits.Length + 1];
                ret[0] = 1;
                Array.Copy(digits, 0, ret, 1, digits.Length);

                return ret;
            }
        }

        return digits;
    }
}