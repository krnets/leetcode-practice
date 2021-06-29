using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 4};
        int expected = 3;
        Assert.Equal(expected, new Solution().NumberOfArithmeticSlices(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1};
        int expected = 0;
        Assert.Equal(expected, new Solution().NumberOfArithmeticSlices(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1, 2, 3};
        int expected = 1;
        Assert.Equal(expected, new Solution().NumberOfArithmeticSlices(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {1, 2, 3, 4, 5, 6};
        int expected = 10;
        Assert.Equal(expected, new Solution().NumberOfArithmeticSlices(nums));
    }
}