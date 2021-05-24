public class Solution
{
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        int[] xors = new int[arr.Length + 1];
        int[] ret = new int[queries.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            xors[i + 1] = arr[i] ^ xors[i];
        }

        for (int i = 0; i < ret.Length; i++)
        {
            int[] q = queries[i];
            int li = q[0];
            int ri = q[1];

            ret[i] = xors[li] ^ xors[ri + 1];
        }

        return ret;
    }
}