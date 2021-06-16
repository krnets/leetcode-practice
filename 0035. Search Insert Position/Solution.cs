/*public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] >= target)
                return i;

        return nums.Length;
    }
}*/

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Length;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] >= target)
                high = mid;
            else low = mid + 1;
        }

        return high;
    }
}