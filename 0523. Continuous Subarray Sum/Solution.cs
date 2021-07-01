using System.Collections.Generic;

/*public class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var map = new Dictionary<int, int> {[0] = -1};
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            sum %= k;

            if (map.ContainsKey(sum))
            {
                if ((i - map[sum]) > 1)
                    return true;
            }
            else map[sum] = i;
        }

        return false;
    }
}*/

public class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var remainderSet = new HashSet<int>();
        int sum = 0;
        int lastRemainder = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            sum %= k;

            if (remainderSet.Contains(sum))
                return true;

            remainderSet.Add(lastRemainder);
            lastRemainder = sum;
        }

        return false;
    }
}