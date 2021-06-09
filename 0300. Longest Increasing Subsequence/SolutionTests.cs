using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {10, 9, 2, 5, 3, 7, 101, 18};
        var expected = 4;
        Assert.Equal(expected, new Solution().LengthOfLIS(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {0, 1, 0, 3, 2, 3};
        var expected = 4;
        Assert.Equal(expected, new Solution().LengthOfLIS(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {7, 7, 7, 7, 7, 7, 7};
        var expected = 1;
        Assert.Equal(expected, new Solution().LengthOfLIS(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {9};
        var expected = 1;
        Assert.Equal(expected, new Solution().LengthOfLIS(nums));
    }
}