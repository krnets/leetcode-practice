using System;
using System.Linq;

public class Solution
{
    public int MyAtoi(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;

        long ans = 0;
        int left = 0;
        int countZeros = 0;

        while (s[left] == ' ')
            left++;

        bool hasNegSign = s[left] == '-';
        bool hasPosSign = s[left] == '+';

        if (hasNegSign || hasPosSign)
            left++;

        while (left < s.Length && char.IsDigit(s[left]) && s[left] == '0')
        {
            left++;
            countZeros++;
        }

        if (left == s.Length || !char.IsDigit(s[left]))
            return 0;

        int right = left + 1;

        while (right < s.Length && char.IsDigit(s[right]))
            right++;

        if (countZeros > 0 && (s.All(c => c == '0') || !char.IsDigit(s[left])))
            return 0;

        int length = right - left;

        for (int i = 0; i < length; i++)
        {
            right--;
            long pow = (long) Math.Pow(10, i);
            long digit = s[right] - '0';
            long mult = pow * digit;
            ans = mult + ans;

            if (hasNegSign && -ans <= int.MinValue)
                return int.MinValue;

            if (ans > int.MaxValue || pow > int.MaxValue)
                return int.MaxValue;
        }

        if (ans == 0) return int.MaxValue;

        return (int) (hasNegSign ? -ans : ans);
    }
}