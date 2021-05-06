/*using System.Collections.Generic;

public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        var list = new List<int>(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            list.Insert(index[i], nums[i]);
        }

        return list.ToArray();
    }
}*/

/*
public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        int[] array = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = array.Length - 1; j > index[i]; j--)
            {
                array[j] = array[j - 1];
            }

            array[index[i]] = nums[i];
        }

        return array;
    }
}
*/

/*public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        int[] array = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            Insert(array, index[i], nums[i]);
        }

        return array;
    }

    private static void Insert(int[] array, int index, int data)
    {
        for (int i = array.Length - 1; i > index; i--)
        {
            array[i] = array[i - 1];
        }

        array[index] = data;
    }
}*/

public class Solution
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        int length = nums.Length;

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            int currIndex = index[i];

            for (int j = length - 1; j > currIndex; j--)
            {
                array[j] = array[j - 1];
            }

            array[currIndex] = nums[i];
        }

        return array;
    }
}