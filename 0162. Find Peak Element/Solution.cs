/*public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = (left + right + 1) / 2;

            if (nums[mid - 1] > nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid;
            }
        }

        return left;
    }
}*/

public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int temp = int.MinValue;
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > temp)
            {
                index = i;
                temp = nums[i];
            }
        }

        return index;
    }
}