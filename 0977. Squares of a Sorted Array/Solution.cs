/*using System;
using System.Linq;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        return nums.Select(x => (int) Math.Pow(Math.Abs(x), 2)).OrderBy(x => x).ToArray();
    }
}*/

/*using System;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int i = right;
        var array = new int[nums.Length];

        while (left <= right)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                array[i] = nums[left] * nums[left];
                left++;
            }
            else
            {
                array[i] = nums[right] * nums[right];
                right--;
            }

            i--;
        }

        return array;
    }
}*/

using System;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int posLeft = 0;
        int posRight = nums.Length - 1;
        var array = new int[nums.Length];

        for (int i = array.Length - 1; posLeft <= posRight; i--)
        {
            int numLeft = Math.Abs(nums[posLeft]);
            int numRight = Math.Abs(nums[posRight]);

            if (numLeft > numRight)
            {
                array[i] = numLeft * numLeft;
                posLeft++;
            }
            else
            {
                array[i] = numRight * numRight;
                posRight--;
            }
        }

        return array;
    }
}