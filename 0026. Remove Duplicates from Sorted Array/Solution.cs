public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int k = 1;
        int last = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != last)
            {
                last = nums[i];
                nums[k] = last;
                k++;
            }
        }

        return k;
    }
}