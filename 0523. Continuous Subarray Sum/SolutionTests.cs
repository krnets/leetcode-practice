using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {23, 2, 4, 6, 7};
        int k = 6;
        Assert.True(new Solution().CheckSubarraySum(nums, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {23, 2, 4, 6, 7};
        int k = 6;
        Assert.True(new Solution().CheckSubarraySum(nums, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {23, 2, 4, 6, 7};
        int k = 13;
        Assert.True(new Solution().CheckSubarraySum(nums, k));
    }
}