public class Solution
{
    public bool CheckPossibility(int[] nums)
    {
        int dropIdx = -1;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                if (dropIdx != -1)
                    return false;

                dropIdx = i;
            }
        }

        return dropIdx < 1 || dropIdx == nums.Length - 2 ||
               nums[dropIdx] <= nums[dropIdx + 2] ||
               nums[dropIdx - 1] <= nums[dropIdx + 1];
    }
}