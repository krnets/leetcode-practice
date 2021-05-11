/*using System;

public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a &&
                        Math.Abs(arr[j] - arr[k]) <= b &&
                        Math.Abs(arr[i] - arr[k]) <= c)
                        count++;
                }
            }
        }

        return count;
    }
}*/

/*using System;

public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int count = 0;

        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) <= a)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[j] - arr[k]) <= b &&
                            Math.Abs(arr[i] - arr[k]) <= c)
                            count++;
                    }
                }
            }
        }

        return count;
    }
}*/

/*using System;

public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int count = 0;

        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) <= a)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (Math.Abs(arr[j] - arr[k]) <= b &&
                            Math.Abs(arr[i] - arr[k]) <= c)
                            count++;
                    }
                }
            }
        }

        return count;
    }
}*/

using System;

public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int count = 0;
        int len = arr.Length;

        for (int i = 0; i < len - 2; i++)
        {
            for (int j = i + 1; j < len - 1; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) <= a)
                {
                    for (int k = j + 1; k < len; k++)
                    {
                        if (Math.Abs(arr[j] - arr[k]) <= b &&
                            Math.Abs(arr[i] - arr[k]) <= c)
                            count++;
                    }
                }
            }
        }

        return count;
    }
}