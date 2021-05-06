public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i && nums[i] > nums[j])
                    count++;
            }

            result[i] = count;
        }

        return result;
    }
}

/*public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                    count++;
            }

            result[i] = count;
        }

        return result;
    }
}*/