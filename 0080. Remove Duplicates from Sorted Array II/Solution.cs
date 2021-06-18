public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int i = 0;

        foreach (var x in nums)
        {
            if (i < 2 || nums[i - 2] != x)
            {
                nums[i] = x;
                i++;
            }
        }

        return i;
    }
}