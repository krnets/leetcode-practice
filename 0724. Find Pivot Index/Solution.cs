using System.Linq;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int sum = nums.Sum();
        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int x = nums[i];
            int rightSum = sum - leftSum - x;

            if (leftSum == rightSum)
                return i;

            leftSum += x;
        }

        return -1;
    }
}