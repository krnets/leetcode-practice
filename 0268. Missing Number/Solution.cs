using System;
using System.Linq;

/*public class Solution
{
    public int MissingNumber(int[] nums)
    {
        return Enumerable.Range(0, nums.Length + 1).Except(nums).First();
    }
}*/

/*public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i <= nums.Length; i++)
            if (i == nums.Length || nums[i] != i)
                return i;

        return 0;
    }
}*/

/*public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = nums.Sum();

        return expectedSum - actualSum;
    }
}*/

/*public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        foreach (var x in nums) 
            actualSum += x;

        return expectedSum - actualSum;
    }
}*/

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            actualSum += nums[i];
        }

        return expectedSum - actualSum;
    }
}