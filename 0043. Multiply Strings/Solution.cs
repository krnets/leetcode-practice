/*public class Solution
{
    public string Multiply(string num1, string num2)
    {
        return (long.Parse(num1) * long.Parse(num2)).ToString();
    }
}*/

/*using System;
using System.Numerics;

public class Solution
{
    public string Multiply(string num1, string num2)
    {
        BigInteger x1 = 0;
        BigInteger x2 = 0;

        int len1 = num1.Length - 1;
        int len2 = num2.Length - 1;

        for (int i = 0; i < num1.Length; i++)
        {
            x1 += (BigInteger) (Math.Pow(10, len1 - i) * (num1[i] - '0'));
        }

        for (int i = 0; i < num2.Length; i++)
        {
            x2 += (BigInteger) (Math.Pow(10, len2 - i) * (num2[i] - '0'));
        }

        return (x1 * x2).ToString();
    }
}*/

using System.Text;

public class Solution
{
    public string Multiply(string num1, string num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;

        int[] pos = new int[len1 + len2];

        for (int i = len1 - 1; i >= 0; i--)
        {
            for (int j = len2 - 1; j >= 0; j--)
            {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int sum = mul + pos[i + j + 1];

                pos[i + j + 1] = sum % 10;
                pos[i + j] += sum / 10;
            }
        }

        var sb = new StringBuilder();

        foreach (int p in pos)
            if (sb.Length > 0 || p > 0)
                sb.Append(p);

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}