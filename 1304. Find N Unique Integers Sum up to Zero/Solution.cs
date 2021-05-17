/*public class Solution
{
    public int[] SumZero(int n)
    {
        var result = new int[n];

        for (int i = 0; i <= n / 2; i++)
        {
            result[i] = -(i + 1);
            result[n - i - 1] = i + 1;
        }

        if (n % 2 == 1)
            result[n / 2] = 0;

        return result;
    }
}*/

public class Solution
{
    public int[] SumZero(int n)
    {
        var result = new int[n];
        int sum = 0;

        for (int i = 1; i < n; i++)
        {
            result[i] = i;
            sum += i;
        }

        result[0] = -sum;

        return result;
    }
}