using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] timeSeries = {1, 4};
        int duration = 2;
        int expected = 4;
        Assert.Equal(expected, new Solution().FindPoisonedDuration(timeSeries, duration));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] timeSeries = {1, 2};
        int duration = 2;
        int expected = 3;
        Assert.Equal(expected, new Solution().FindPoisonedDuration(timeSeries, duration));
    }
}