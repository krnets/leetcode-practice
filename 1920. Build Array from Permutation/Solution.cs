public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int n = nums.Length;
        var arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = nums[nums[i]];
        }

        return arr;
    }
}