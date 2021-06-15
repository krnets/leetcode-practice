/*public class Solution
{
    public bool ContainsPattern(int[] arr, int m, int k)
    {
        for (int i = 0; i < arr.Length - m; i++)
        {
            int[] slice = arr[i..(i + m)];
            int r = k - 1;
            int pos = (i + m);

            while (r > 0)
            {
                for (int j = 0; j < m; j++)
                {
                    if (pos == arr.Length || slice[j] != arr[pos])
                        goto outer;

                    pos++;
                }

                r--;
            }

            if (r == 0)
                return true;

            outer: ;
        }

        return false;
    }
}*/

using System.Linq;

public class Solution
{
    public bool ContainsPattern(int[] arr, int m, int k)
    {
        int maxLen = m * k;

        for (int i = 0; i < arr.Length - m; i++)
        {
            int[] slice = arr[i..(i + m)];

            var repeat = Enumerable.Repeat(slice, k)
                .SelectMany(x => x)
                .ToArray();

            if ((i + maxLen) <= arr.Length)
                if (arr[i..(i + maxLen)].SequenceEqual(repeat))
                    return true;
        }

        return false;
    }
}