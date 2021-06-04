using System.Linq;

public class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int countZeros = arr.Count(x => x == 0);
        int increasedArraySize = countZeros + arr.Length;
        int i = arr.Length - 1;
        int j = increasedArraySize - 1;

        while (i != j)
        {
            insert(arr, i, j--);

            if (arr[i] == 0)
                insert(arr, i, j--);

            i--;
        }
    }

    private void insert(int[] arr, int i, int j)
    {
        if (j < arr.Length)
            arr[j] = arr[i];
    }
}