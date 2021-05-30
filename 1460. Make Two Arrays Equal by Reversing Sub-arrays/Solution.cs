/*using System;
using System.Linq;

public class Solution
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        Array.Sort(target);
        Array.Sort(arr);
        return target.SequenceEqual(arr);
    }
}*/

/*using System;

public class Solution
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        Array.Sort(target);
        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
            if (target[i] != arr[i])
                return false;

        return true;
    }
}*/

public class Solution
{
    public bool CanBeEqual(int[] target, int[] arr)
    {
        int[] diff = new int[1001];

        for (int i = 0; i < target.Length; i++)
        {
            diff[target[i]]++;
            diff[arr[i]]--;
        }

        for (int i = 0; i < diff.Length; i++)
            if (diff[i] != 0)
                return false;

        return true;
    }
}