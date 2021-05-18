/*using System.Linq;

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[(i + 1)..].Max();
        }

        arr[^1] = -1;

        return arr;
    }
}*/

/*using System;

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = max;
            max = Math.Max(max, temp);
        }

        return arr;
    }
}*/

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = max;

            if (temp > max)
                max = temp;
        }

        return arr;
    }
}