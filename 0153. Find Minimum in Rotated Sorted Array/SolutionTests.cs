using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {3, 4, 5, 1, 2};
        int expected = 1;
        Assert.Equal(expected, new Solution().FindMin(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {4, 5, 6, 7, 0, 1, 2};
        int expected = 0;
        Assert.Equal(expected, new Solution().FindMin(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {11, 13, 15, 17};
        int expected = 11;
        Assert.Equal(expected, new Solution().FindMin(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {2, 1};
        int expected = 1;
        Assert.Equal(expected, new Solution().FindMin(nums));
    }
}