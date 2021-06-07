using System;

/*public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        if (x == 0) return true;

        var digits = new int[(int) Math.Floor(Math.Log10(x)) + 1];
        int i = 0;

        while (x != 0)
        {
            digits[i] = x % 10;
            x /= 10;
            i++;
        }

        int left = 0;
        int right = digits.Length - 1;

        while (left < right)
        {
            if (digits[left] != digits[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}*/

public class Solution
{
    public bool IsPalindrome(int x)
    {
        int y = x;
        int z = 0;

        while (y > 0)
        {
            z = z * 10 + y % 10;
            y /= 10;
        }

        return z == x;
    }
}