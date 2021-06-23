using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {3, 2, 1};
        int expected = 1;
        Assert.Equal(expected, new Solution().ThirdMax(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 2};
        int expected = 2;
        Assert.Equal(expected, new Solution().ThirdMax(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {2, 2, 3, 1};
        int expected = 1;
        Assert.Equal(expected, new Solution().ThirdMax(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {1, 2, -2147483648};
        int expected = -2147483648;
        Assert.Equal(expected, new Solution().ThirdMax(nums));
    }
}