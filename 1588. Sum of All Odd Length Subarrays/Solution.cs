/*public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        int n = arr.Length;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += ((i + 1) * (n - i) + 1) / 2 * arr[i];
        }

        return sum;
    }
}*/

using System.Linq;

public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        int n = arr.Length;

        return arr.Select((x, i) => ((i + 1) * (n - i) + 1) / 2 * x).Sum();
    }
}

/*public class Solution
{
    public int SumOddLengthSubarrays(int[] arr)
    {
        int total = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int sum = 0;

            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];

                if ((j - i + 1) % 2 != 0)
                    total += sum;
            }
        }

        return total;
    }
}*/