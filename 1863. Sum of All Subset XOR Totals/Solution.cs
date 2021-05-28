/*using System.Linq;

public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int n = nums.Length - 1;

        return (1 << n) * nums.Aggregate(0, (current, num) => current | num);
    }
}*/

public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int n = nums.Length - 1;
        int bits = 0;

        foreach (int num in nums)
        {
            bits |= num;
        }

        return (1 << n) * bits;
    }
}