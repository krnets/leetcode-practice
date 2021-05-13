using System.Collections.Generic;

public class Solution
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        var set = new SortedSet<long>();

        for (int i = 0; i < nums.Length; i++)
        {
            long n = nums[i];

            if (i > k)
                set.Remove(nums[i - k - 1]);

            if (t >= 0 && set.GetViewBetween(n - t, n + t).Count > 0)
                return true;

            set.Add(n);
        }

        return false;
    }
}