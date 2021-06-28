using System;
using System.Collections.Generic;

/*public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;
        var list = new List<int> {0};
        list.AddRange(flowerbed);
        list.Add(0);

        for (int i = 1; i < list.Count - 1; i++)
        {
            if (list[i] == 0)
            {
                if (list[i] == list[i - 1] && list[i] == list[i + 1])
                {
                    list[i] = 1;
                    count++;
                }
            }
        }

        return count >= n;
    }
}*/

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;
        int len = flowerbed.Length;
        var arr = new int[len + 2];
        Array.Copy(flowerbed, 0, arr, 1, len);

        for (int i = 1; i <= len; i++)
        {
            if (arr[i] == 0)
            {
                int prev = arr[i - 1];
                int next = arr[i + 1];

                if (prev == arr[i] && arr[i] == next)
                {
                    arr[i] = 1;
                    count++;
                }
            }
        }

        return count >= n;
    }
}