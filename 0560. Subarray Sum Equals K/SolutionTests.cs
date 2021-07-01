using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 1, 1};
        int k = 2;
        int expected = 2;
        Assert.Equal(expected, new Solution().SubarraySum(nums, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 2, 3};
        int k = 3;
        int expected = 2;
        Assert.Equal(expected, new Solution().SubarraySum(nums, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {-1, -1, 1};
        int k = 0;
        int expected = 1;
        Assert.Equal(expected, new Solution().SubarraySum(nums, k));
    }
}