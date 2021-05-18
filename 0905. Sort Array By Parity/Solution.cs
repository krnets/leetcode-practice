/*using System.Linq;

public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        return nums.Where(x => x % 2 == 0).Concat(nums.Where(x => x % 2 == 1)).ToArray();
    }
}*/

using System;

public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        Array.Sort(nums, (a, b) => a % 2 == b % 2 ? a - b : a % 2 == 0 ? -1 : 1);

        return nums;
    }
}