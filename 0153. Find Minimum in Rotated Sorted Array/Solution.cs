using System;

public class Solution
{
    public int FindMin(int[] nums)
    {
        int ans = nums[0];
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            if (nums[left] < nums[right])
            {
                ans = Math.Min(ans, nums[left]);
                break;
            }

            int mid = (left + right) / 2;
            ans = Math.Min(ans, nums[mid]);

            if (nums[mid] >= nums[left])
                left = mid + 1;
            else
                right = mid - 1;
        }

        return ans;
    }
}