using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {4, 5, 0, -2, -3, 1};
        int k = 5;
        int expected = 7;
        Assert.Equal(expected, new Solution().SubarraysDivByK(nums, k));
    }
}