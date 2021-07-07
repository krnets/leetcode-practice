using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        int expected = 6;
        Assert.Equal(expected, new Solution().MaxSubArray(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1};
        int expected = 1;
        Assert.Equal(expected, new Solution().MaxSubArray(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {5, 4, -1, 7, 8};
        int expected = 23;
        Assert.Equal(expected, new Solution().MaxSubArray(nums));
    }
}