public class Solution
{
    public int Search(int[] nums, int target)
    {
        int n = nums.Length;
        int low = 0;
        int high = n - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (nums[mid] > nums[high])
                low = mid + 1;
            else high = mid;
        }

        int offset = low;
        low = 0;
        high = n - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int realMid = (mid + offset) % n;

            if (nums[realMid] == target)
                return realMid;

            if (nums[realMid] < target)
                low = mid + 1;
            else high = mid - 1;
        }

        return -1;
    }
}

/*using System;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        return Array.IndexOf(nums, target);
    }
}*/