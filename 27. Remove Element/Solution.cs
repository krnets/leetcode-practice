/*public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                if (i != k)
                {
                    nums[k] = nums[i];
                    nums[i] = val;
                }

                k++;
            }
        }

        return k;
    }
}*/

/*public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
                continue;

            nums[k++] = nums[i];
        }

        return k;
    }
}*/

/*public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
                count++;
            else
                nums[i - count] = nums[i];
        }

        return nums.Length - count;
    }
}*/

/*public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int tail = 0;

        foreach (var num in nums)
            if (num != val)
            {
                nums[tail] = num;
                tail++;
            }

        return tail;
    }
}*/

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int j = nums.Length;

        for (int i = 0; i < j;)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[j - 1];
                j--;
            }
            else i++;
        }

        return j;
    }
}