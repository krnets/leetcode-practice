public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var result = new int[nums.Length];
        int mid = nums.Length / 2;

        for (int i = 0, j = 0; i < mid; i++, j += 2)
        {
            result[j] = nums[i];
            result[j + 1] = nums[mid + i];
        }

        return result;
    }
}

// GC.Collect();