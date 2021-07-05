using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {5, 6, 2, 7, 4};
        int expected = 34;
        Assert.Equal(expected, new Solution().MaxProductDifference(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {4, 2, 5, 9, 7, 4, 8};
        int expected = 64;
        Assert.Equal(expected, new Solution().MaxProductDifference(nums));
    }
}