/*public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = -1;
        int last = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                first = i;
                break;
            }
        }

        if (first != -1)
        {
            for (int i = nums.Length - 1; i >= first; i--)
            {
                if (nums[i] == target)
                {
                    last = i;
                    break;
                }
            }
        }

        return new[] {first, last};
    }
}*/

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = -1;
        int last = -1;

        int low = 0;
        int high = nums.Length;
        int indexFound = -1;

        while (low < high)
        {
            int mid = (high + low) / 2;

            if (nums[mid] == target)
            {
                indexFound = mid;
                break;
            }

            if (nums[mid] < target)
                low = mid + 1;
            else
                high = mid;
        }

        if (indexFound != -1)
        {
            for (int j = indexFound; j >= 0; j--)
            {
                if (j == 0)
                    first = j;

                if (nums[j] != target)
                {
                    first = j + 1;
                    break;
                }
            }

            for (int j = indexFound; j < nums.Length; j++)
            {
                if (j == nums.Length - 1)
                    last = j;

                if (nums[j] != target)
                {
                    last = j - 1;
                    break;
                }
            }
        }

        return new[] {first, last};
    }
}