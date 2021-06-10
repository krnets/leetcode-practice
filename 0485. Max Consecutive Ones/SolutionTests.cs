using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 1, 0, 1, 1, 1};
        var expected = 3;
        Assert.Equal(expected, new Solution().FindMaxConsecutiveOnes(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 0, 1, 1, 0, 1};
        var expected = 2;
        Assert.Equal(expected, new Solution().FindMaxConsecutiveOnes(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {0};
        var expected = 0;
        Assert.Equal(expected, new Solution().FindMaxConsecutiveOnes(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {1, 1, 0, 1};
        var expected = 2;
        Assert.Equal(expected, new Solution().FindMaxConsecutiveOnes(nums));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums = {0, 0};
        var expected = 0;
        Assert.Equal(expected, new Solution().FindMaxConsecutiveOnes(nums));
    }
}