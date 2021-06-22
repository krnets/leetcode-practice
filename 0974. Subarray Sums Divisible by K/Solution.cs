public class Solution
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        int sum = 0;
        int count = 0;
        int[] remainders = new int[k];
        remainders[0] = 1;

        foreach (var x in nums)
        {
            sum = (sum + x) % k;

            if (sum < 0)
                sum += k;

            count += remainders[sum];
            remainders[sum]++;
        }

        return count;
    }
}