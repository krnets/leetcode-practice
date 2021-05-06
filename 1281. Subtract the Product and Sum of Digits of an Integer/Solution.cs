/*public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int product = 1;
        int sum = 0;

        while (n != 0)
        {
            var x = n % 10;
            product *= x;
            sum += x;
            n /= 10;
        }

        return product - sum;
    }
}*/

/*using System.Linq;

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        var product = 1.0;
        var sum = 0.0;
        var digits = n.ToString().Select(char.GetNumericValue).ToArray();

        for (int i = 0; i < digits.Length; i++)
        {
            product *= digits[i];
            sum += digits[i];
        }

        return (int) (product - sum);
    }
}*/

using System.Linq;

public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        var product = 1.0;
        var sum = 0.0;
        var digits = n.ToString().Select(char.GetNumericValue).ToArray();

        foreach (var d in digits)
        {
            product *= d;
            sum += d;
        }

        return (int) (product - sum);
    }
}