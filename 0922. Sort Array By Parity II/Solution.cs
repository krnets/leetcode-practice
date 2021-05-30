public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        for (int i = 0, j = 1; i < nums.Length; i += 2)
        {
            if (nums[i] % 2 == 1)
            {
                while (nums[j] % 2 == 1)
                    j += 2;

                (nums[i], nums[j]) = (nums[j], nums[i]);
            }
        }

        return nums;
    }
}

/*public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        int even = 0;
        int odd = 1;

        while (even < nums.Length && odd < nums.Length)
        {
            if (nums[even] % 2 == 1 && nums[odd] % 2 == 0)
            {
                (nums[even], nums[odd]) = (nums[odd], nums[even]);
            }

            if (nums[even] % 2 == 0) even += 2;
            if (nums[odd] % 2 == 1) odd += 2;
        }

        return nums;
    }
}*/