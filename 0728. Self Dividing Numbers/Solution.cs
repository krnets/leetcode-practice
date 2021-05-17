using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        return Enumerable.Range(left, right - left + 1)
            .Where(IsSelfDividing)
            .ToList();
    }

    private bool IsSelfDividing(int n)
    {
        var q = n;

        while (q != 0)
        {
            var r = q % 10;

            if (r == 0 || n % r != 0)
                return false;

            q /= 10;
        }

        return true;
    }
}

/*
private bool IsSelfDividing(int n)
{
    var digits = new List<int>();
    var q = n;

    while (q != 0)
    {
        var remainder = q % 10;

        if (remainder == 0)
            return false;

        digits.Add(remainder);
        q /= 10;
    }

    return digits.All(d => n % d == 0);
}
*/