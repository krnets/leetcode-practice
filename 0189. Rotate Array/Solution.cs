/*public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        while (k > 0)
        {
            int last = nums[^1];

            for (int i = nums.Length - 1; i > 0; i--)
            {
                (nums[i], nums[i - 1]) = (nums[i - 1], nums[i]);
            }

            nums[0] = last;

            k--;
        }
    }
}*/

/*public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var small = new int[k];
        k = k % nums.Length;
        int offsetStart = nums.Length - k;

        for (int i = 0; i < k; i++)
        {
            small[i] = nums[offsetStart + i];
        }

        for (int i = nums.Length - 1; i >= k; i--)
        {
            nums[i] = nums[i - k];
        }

        for (int i = 0; i < k; i++)
        {
            nums[i] = small[i];
        }
    }
}*/

/*public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        SetNums(nums, k, 0);
    }

    private void SetNums(int[] nums, int k, int i)
    {
        if (i == nums.Length - 1)
        {
            nums[(i + k) % nums.Length] = nums[i];
        }
        else
        {
            int temp = nums[i];
            SetNums(nums, k, i + 1);
            nums[(i + k) % nums.Length] = temp;
        }
    }
}*/

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
}

/*public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;
        int elemCount = 0;

        for (int i = 0; elemCount < nums.Length; i++)
        {
            int j = i;
            int prev = nums[i];

            do
            {
                int nextPos = (j + k) % nums.Length;
                int temp = nums[nextPos];

                nums[nextPos] = prev;
                prev = temp;

                j = nextPos;
                elemCount++;
            } while (j != i);
        }
    }
}*/