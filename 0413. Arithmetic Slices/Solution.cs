/*public class Solution
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        int ans = 0;
        int length = 1;

        for (int i = 2; i < nums.Length; i++)
        {
            int a = nums[i - 2];
            int b = nums[i - 1];
            int c = nums[i];

            if (a - b == b - c)
            {
                ans += length;
                length++;
            }
            else length = 1;
        }

        return ans;
    }
}*/

/*public class Solution
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        int count = 0;
        var dp = new int[nums.Length];

        for (int i = 2; i < nums.Length; i++)
        {
            int a = nums[i - 2];
            int b = nums[i - 1];
            int c = nums[i];

            if (a - b == b - c)
            {
                dp[i] = dp[i - 1] + 1;
                count += dp[i];
            }
        }

        return count;
    }
}*/

public class Solution
{
    private int sum;

    public int NumberOfArithmeticSlices(int[] nums)
    {
        DFS(nums, nums.Length - 1);

        return sum;
    }

    private int DFS(int[] nums, int i)
    {
        if (i < 2) return 0;

        int res = 0;
        int a = nums[i - 2];
        int b = nums[i - 1];
        int c = nums[i];

        if (a - b == b - c)
        {
            res = 1 + DFS(nums, i - 1);
            sum += res;
        }
        else DFS(nums, i - 1);

        return res;
    }
}