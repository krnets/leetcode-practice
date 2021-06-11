using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 1};
        int expected = 2;
        Assert.Equal(expected, new Solution().FindPeakElement(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 2, 1, 3, 5, 6, 4};
        int expected = 5;
        Assert.Equal(expected, new Solution().FindPeakElement(nums));
    }
}