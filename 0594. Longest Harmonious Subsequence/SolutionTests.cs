using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 3, 2, 2, 5, 2, 3, 7};
        int expected = 5;
        Assert.Equal(expected, new Solution().FindLHS(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 2, 3, 4};
        int expected = 2;
        Assert.Equal(expected, new Solution().FindLHS(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1, 1, 1, 1};
        int expected = 0;
        Assert.Equal(expected, new Solution().FindLHS(nums));
    }
}