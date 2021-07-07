using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {2, 3, -2, 4};
        int expected = 6;
        Assert.Equal(expected, new Solution().MaxProduct(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {-2, 0, -1};
        int expected = 0;
        Assert.Equal(expected, new Solution().MaxProduct(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {-3, -1, -1};
        int expected = 3;
        Assert.Equal(expected, new Solution().MaxProduct(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {3, -1, 4};
        int expected = 4;
        Assert.Equal(expected, new Solution().MaxProduct(nums));
    }
}