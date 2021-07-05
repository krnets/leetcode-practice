using System;
using System.Linq;

/*public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        Array.Sort(nums);
        var prodSmallest = nums.Take(2).Aggregate((x, y) => x * y);
        var prodLargest = nums.TakeLast(2).Aggregate((x, y) => x * y);

        return prodLargest - prodSmallest;
    }
}*/

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        if (nums.Length < 4) return 0;

        Array.Sort(nums);

        return (nums[^1] * nums[^2]) - (nums[0] * nums[1]);
    }
}