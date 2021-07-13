/*public class Solution
{
    public bool CanBeIncreasing(int[] nums)
    {
        int countNonIncreasing = 0;
        int index = -1;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] >= nums[i + 1])
            {
                countNonIncreasing++;
                index = i;
            }
        }

        if (countNonIncreasing == 0)
            return true;

        if (countNonIncreasing == 1)
        {
            if (index == 0 || index == nums.Length - 2)
                return true;

            if (nums[index - 1] < nums[index + 1])
                return true;

            if (index + 2 < nums.Length)
                if (nums[index] < nums[index + 2])
                    return true;
        }

        return false;
    }
}*/

public class Solution
{
    public bool CanBeIncreasing(int[] nums)
    {
        int countNonIncreasing = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] >= nums[i])
            {
                countNonIncreasing++;

                if (countNonIncreasing > 1)
                    return false;

                if (i > 1 && i < nums.Length - 1
                          && nums[i - 2] >= nums[i]
                          && nums[i - 1] >= nums[i + 1])
                    return false;
            }
        }

        return true;
    }
}