using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private Dictionary<int, int> mirrorDigit = new Dictionary<int, int>()
        {[0] = 0, [1] = 1, [2] = 5, [5] = 2, [6] = 9, [8] = 8, [9] = 6};

    public int RotatedDigits(int n)
    {
        return Enumerable.Range(1, n)
            .Where(IsRotated)
            .Count();
    }

    private bool IsRotated(int n)
    {
        if (n < 10)
            return mirrorDigit.ContainsKey(n) && mirrorDigit[n] != n;

        var digits = new List<int>();
        var x = n;

        while (x != 0)
        {
            int y = x % 10;

            if (!mirrorDigit.ContainsKey(y))
                return false;

            digits.Insert(0, mirrorDigit[y]);

            x /= 10;
        }

        var str = string.Concat(digits);
        var num = int.Parse(str);

        return num != n;
    }
}